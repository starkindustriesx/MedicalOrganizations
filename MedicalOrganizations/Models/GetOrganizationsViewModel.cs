﻿using MedicalOrganizations.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalOrganizations.Models
{
    public class GetOrganizationsViewModel
    {
        public IEnumerable<TableMedicalOrganizations> Organizations { get; set; }
    }
}
