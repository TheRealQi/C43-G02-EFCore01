using Microsoft.EntityFrameworkCore;


namespace EFCoreAssi1.DBContext
{
    public class ITIDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI_DB; Trusted_Connection = true; TrustServerCertificate=True");
        }
    }
}