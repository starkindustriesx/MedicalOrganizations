using MedicalOrganizations.Data;
using MedicalOrganizations.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalOrganizations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : Controller
    {
        private DBMedicalOrganizationsContext _dBContext;

        public OrganizationController(DBMedicalOrganizationsContext dBContext)
        {
            _dBContext = dBContext;
        }

        [HttpGet("getorganizations")]
        public IActionResult GetOrganizationsView()
        {
            try
            {
                IEnumerable<TableMedicalOrganizations> organizations = _dBContext.TableMedicalOrganizations;

                if (organizations.Count() == 0)
                {
                    return StatusCode(404, "No organization found");
                }
                GetOrganizationsViewModel getOrganizations = new GetOrganizationsViewModel
                {
                    Organizations = organizations
                };
                return View(getOrganizations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }           
        }

        [HttpGet("byname")]
        public IActionResult GetByNameView(string search)
        {
            try
            {
                IEnumerable<TableMedicalOrganizations> organizations = _dBContext.TableMedicalOrganizations.Where(n => n.Name.ToLower().Contains(search.ToLower()));
                if (organizations == null)
                {
                    return StatusCode(404, "No organization found");
                }
                GetByNameViewModel getByNameViewModel = new GetByNameViewModel
                {
                    Organizations = organizations
                };

                return View(getByNameViewModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("bywords")]
        public IActionResult GetByWordsView(string query)
        {
            try
            {
                string[] words = query.Split(' ');
                IEnumerable<TableMedicalOrganizations> organizations = _dBContext.TableMedicalOrganizations;
                foreach (string word in words)
                {
                    organizations = organizations.Where(n => n.Name.ToLower().Contains(word.ToLower()));
                    if (organizations == null)
                        return StatusCode(404, "No organization found");
                }
                GetByWordsViewModel getByWordsViewModel = new GetByWordsViewModel
                {
                    Organizations = organizations
                };
                return View(getByWordsViewModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIDView(string id)
        {
            try
            {
                var organization = _dBContext.TableMedicalOrganizations.FirstOrDefault(n => n.Id == id);
                if (organization == null)
                {
                    return StatusCode(404, "No organization found");
                }
                GetByIdViewModel getByIdViewModel = new GetByIdViewModel
                {
                    Organization = organization
                };
                return View(getByIdViewModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("pages")]
        public ViewResult ListView(int skip = 1, int take = 50, int page = 1, SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 10;

            IQueryable<TableMedicalOrganizations> organizations = _dBContext.TableMedicalOrganizations.AsQueryable();

            switch (sortOrder)
            {
                case SortState.NameDesc:
                    organizations = organizations.OrderByDescending(s => s.Name);
                    break;
                case SortState.IdAsc:
                    organizations = organizations.OrderBy(s => s.Id);
                    break;
                case SortState.IdDesc:
                    organizations = organizations.OrderByDescending(s => s.Id);
                    break;
                default:
                    organizations = organizations.OrderBy(s => s.Name);
                    break;
            }

            organizations = organizations.Skip(skip).Take(take);

            var count = organizations.Count();
            var items = organizations.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ListViewModel viewModel = new ListViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(organizations.ToList(), skip, take),
                Organizations = items
            };

            return View(viewModel);
        }
    }
}
