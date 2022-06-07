using Microsoft.EntityFrameworkCore;

namespace weather_app_crewin.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EHVPQGR;Initial Catalog=weather_App;Integrated Security=True;Pooling=False");
        }

        public DbSet<weather_info>weather_infos { get; set; }
        //public DbSet<cities> cities { get; set; }
    }
}
