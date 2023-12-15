using At.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Persistance.Configurations
{
    public sealed class TaskReportConfigurations : IEntityTypeConfiguration<TaskReport>
    {
        public void Configure(EntityTypeBuilder<TaskReport> builder)
        {
            builder.Property(x => x.Detail).IsRequired(true);
            builder.Property(x=>x.Definition).IsRequired(true);
            builder.Property(x=>x.Definition).HasMaxLength(250);
            builder.Property(x=>x.AppTaskId).IsRequired(true);
        }
    }
}
