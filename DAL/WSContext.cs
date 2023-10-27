using Microsoft.EntityFrameworkCore;
using models.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WSContext : DbContext
    {
        public virtual DbSet<Workshop> Workshops { get; set; }
        public virtual DbSet<Tutorial> Tutorials { get; set; }
        public virtual DbSet<TutorialStep> TutorialSteps { get; set; }

        public WSContext()
        {
        }

        public WSContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
