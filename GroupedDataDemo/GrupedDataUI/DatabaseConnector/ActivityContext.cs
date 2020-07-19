using GroupedData.Presentation.Activity;
using Microsoft.EntityFrameworkCore;


namespace GrupedDataUI.DatabaseConnector
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions options) : base(options) { }
        public DbSet<ActivityModel> Activities { get; set; }
    }
}
