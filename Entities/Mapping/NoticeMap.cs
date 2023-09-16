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
    public class NoticeMap : EntityTypeConfiguration<Notice>
    {
        public NoticeMap()
        {
            this.ToTable("Notice");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); 
            this.Property(x=>x.Title).HasColumnType("varchar");
            this.Property(x => x.Title).IsRequired().HasMaxLength(150);
            this.Property(x => x.Announcement).IsRequired().HasMaxLength(500);
            this.Property(x => x.Description).HasMaxLength(5000);

            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Title).HasColumnName("Title");
            this.Property(x => x.Announcement).HasColumnName("Announcement");
            this.Property(x => x.Description).HasColumnName("Description");
            this.Property(x => x.Date).HasColumnName("Date");
        }
    }
}
