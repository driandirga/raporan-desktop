using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raporan_Desktop.Data
{
    public class ApplicationDbContext : DbContext
    {
        private static readonly Lazy<ApplicationDbContext> _lazyInstance =
        new Lazy<ApplicationDbContext>(() => new ApplicationDbContext());

        public static ApplicationDbContext Instance => _lazyInstance.Value;

        private ApplicationDbContext()
            : base("Server=localhost\\SQLEXPRESS;Database=rapmasterdb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true")
        {

        }

        public DbSet<User> Users { get; set; }
        // Add other DbSet properties for each of your entities

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Your configuration code for the database model
            // modelBuilder.Configurations.Add(new YourEntityConfiguration());
        }
    }
}
