using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconciliationApp.Core.Entities.Concrete
{
    public class UserCompany
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
