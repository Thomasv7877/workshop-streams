using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.configurations
{
    internal class TutorialConfiguration : IEntityTypeConfiguration<Tutorial>
    {
        public void Configure(EntityTypeBuilder<Tutorial> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasMany(t => t.steps).WithOne();
        }
    }
}
