﻿using Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class BookMovementMap : EntityTypeConfiguration<BookMovement>
    {
        public BookMovementMap()
        {
            this.ToTable("BookMovement");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.ActionTaken).IsRequired().HasMaxLength(150);

            this.HasRequired(x => x.Book).WithMany(x => x.BookMovement).HasForeignKey(x => x.BookId);
        }
    }
}
