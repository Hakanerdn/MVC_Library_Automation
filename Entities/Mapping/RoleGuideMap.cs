using Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class RoleGuideMap : EntityTypeConfiguration<RoleGuide>
    {
        public RoleGuideMap()
        {
            this.ToTable("RoleGuide");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Role).IsRequired().HasMaxLength(50);
        }
    }
}
