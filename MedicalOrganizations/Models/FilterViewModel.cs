using MedicalOrganizations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalOrganizations.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<TableMedicalOrganizations> organizations, int skip, int take)
        {
            Organizations = organizations;
            Skip = skip;
            Take = take;
        }
        public List<TableMedicalOrganizations> Organizations { get; private set; }
        public int Skip { get; private set; }
        public int Take { get; private set; }
    }
}
