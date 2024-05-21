using Microsoft.EntityFrameworkCore;

namespace Meetup.DAL
{
    public class MtContext:DbContext
    {
        public MtContext(DbContextOptions<MtContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CA-R214-PC07\\SQLEXPRESS;Database = Spering;Trusted_Connection = True;TrustServerCertificate=True");
            base.OnConfiguring(options);
            
        }
    }
}
