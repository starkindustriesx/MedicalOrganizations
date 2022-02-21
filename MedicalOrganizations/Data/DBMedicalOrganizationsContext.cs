using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalOrganizations.Data
{
    public class DBMedicalOrganizationsContext : DbContext
    {
        public DBMedicalOrganizationsContext(DbContextOptions<DBMedicalOrganizationsContext> options) : base(options)
        {

        }

        public DbSet<TableMedicalOrganizations> TableMedicalOrganizations { get; set; }
    }
}
