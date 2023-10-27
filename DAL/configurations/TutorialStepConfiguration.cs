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
    public class TutorialStepConfiguration : IEntityTypeConfiguration<TutorialStep>
    {
        public void Configure(EntityTypeBuilder<TutorialStep> builder)
        {
            builder.HasKey(t => t.Id);

        }
    }
}
