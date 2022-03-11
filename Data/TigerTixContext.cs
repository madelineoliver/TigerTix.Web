using Microsoft.EntityFrameworkCore;
using TigerTix.Web.Data.Entities;

namespace TigerTix.Web.Data
{
    public class TigerTixContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
