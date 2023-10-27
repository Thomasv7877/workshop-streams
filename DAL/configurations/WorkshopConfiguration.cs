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
    internal class WorkshopConfiguration : IEntityTypeConfiguration<Workshop>
    {
        public void Configure(EntityTypeBuilder<Workshop> builder)
        {
            builder.HasKey(w => w.Id);
            builder.HasOne(w => w.tutorial).WithOne();
        }
    }
}
