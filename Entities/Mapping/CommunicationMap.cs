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
    public class CommunicationMap : EntityTypeConfiguration<Communication>
    {
        public CommunicationMap()
        {
            this.ToTable("Communication");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.NameSurname).IsRequired().HasMaxLength(100);
            this.Property(x => x.Email).IsRequired().HasMaxLength(150);
            this.Property(x => x.Title).IsRequired().HasMaxLength(200);
            this.Property(x => x.Message).IsRequired().HasMaxLength(500);
            this.Property(x => x.Description).IsRequired().HasMaxLength(5000);
        }
    }
}
