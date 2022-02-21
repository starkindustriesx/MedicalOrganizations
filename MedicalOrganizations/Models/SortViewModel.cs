using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalOrganizations.Models
{
    public enum SortState
    {
        NameAsc,    
        NameDesc,   
        IdAsc,
        IdDesc
    }

    public class SortViewModel
    {
        public SortState NameSort { get; private set; }
        public SortState IdSort { get; private set; }
        public SortState Current { get; private set; }

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            IdSort = sortOrder == SortState.IdAsc ? SortState.IdDesc : SortState.IdAsc;
            Current = sortOrder;
        }
    }
}
