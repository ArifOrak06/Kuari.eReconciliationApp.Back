using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconciliationApp.Core.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsActive { get; set; }
        public bool MailConfirm { get; set; }
        public int MailConfirmValue { get; set; }
        public DateTime MailConfirmDate { get; set; }

    }
}
