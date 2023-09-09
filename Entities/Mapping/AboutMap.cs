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
    public class AboutMap : EntityTypeConfiguration<About>
    {
        public AboutMap()
        {
            this.ToTable("About");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x=>x.Content).IsRequired().HasMaxLength(500);
            this.Property(x=>x.Description).HasMaxLength(5000);
        }
    }
}
