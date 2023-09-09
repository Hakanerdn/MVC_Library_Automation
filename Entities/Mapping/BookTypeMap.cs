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
    public class BookTypeMap : EntityTypeConfiguration<BookType>
    {
        public BookTypeMap()
        {
            this.ToTable("BookType");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Type).IsRequired().HasMaxLength(150);
            this.Property(x => x.Description).IsRequired().HasMaxLength(5000);
        }
    }
}
