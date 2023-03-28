using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconciliationApp.Core.Entities.Concrete
{
    public class BaBsReconciliationDetail
    {
        public int Id { get; set; }
        public int BaBsReconciliationId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }


    }
}
