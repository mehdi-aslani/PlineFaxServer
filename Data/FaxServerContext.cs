using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlineFaxServer.Models;
using PlineFaxServer.Models.Users;

namespace PlineFaxServer.Data
{
    public class FaxServerContext : IdentityDbContext<TblUser>
    {
        public FaxServerContext(DbContextOptions<FaxServerContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        // }

        public DbSet<TblReceiveFax> TblReceiveFax { get; set; }
        public DbSet<TblSendFax> TblSendFax { get; set; }
        public DbSet<TblContact> TblContact { get; set; }
    }
}