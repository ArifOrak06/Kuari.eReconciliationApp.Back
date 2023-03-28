using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconciliationApp.Core.Entities.Concrete
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TaxDepartment { get; set; }
        public string? TaxIdentityNumber { get; set; }
        public string? IdentityNumber { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
