using eReconciliationApp.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconciliationApp.Repository.Contexts
{
    public class EReconciliationAppDbContext : DbContext
    {


        public EReconciliationAppDbContext(DbContextOptions<EReconciliationAppDbContext> options) : base(options)
        {

        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AccountReconciliation> AccountReconciliations { get; set; } 
        public DbSet<AccountReconciliationDetail> AccountReconciliationDetails { get; set; } 
        public DbSet<BaBsReconciliation> BaBsReconciliations { get; set; } 
        public DbSet<BaBsReconciliationDetail> BaBsReconciliationDetails { get; set; } 
        public DbSet<Company> Companies { get; set; } 
        public DbSet<Currency> Currencies { get; set; } 
        public DbSet<CurrencyAccount> CurrencyAccounts { get; set; }
        public DbSet<MailParameter> MailParameters { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }



    }
}
