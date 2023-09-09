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
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            this.ToTable("Book");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Barcodeno).IsRequired().HasMaxLength(30);
            this.Property(x => x.BookName).IsRequired().HasMaxLength(100);
            this.Property(x => x.AuthorName).IsRequired().HasMaxLength(100);
            this.Property(x => x.Publisher).IsRequired().HasMaxLength(150);
            this.Property(x => x.Description).HasMaxLength(5000);
        }
    }
}
