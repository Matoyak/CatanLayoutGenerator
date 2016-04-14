using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace CatanLayoutGenerator.Models {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public DbSet<BoardLayout> BoardLayouts { get; set; }
        public DbSet<UserBoard> UserBoards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<UserBoard>().HasKey(x => new { x.BoardLayoutId, x.UserId });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
