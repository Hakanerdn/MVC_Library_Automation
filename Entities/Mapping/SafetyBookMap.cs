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
    public class SafetyBookMap : EntityTypeConfiguration<SafetyBook>
    {
        public SafetyBookMap()
        {
            this.ToTable("SafetyBook");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(x => x.Book).WithMany(x => x.SafetyBook).HasForeignKey(x => x.BookId);
            this.HasRequired(x => x.Member).WithMany(x => x.SafetyBook).HasForeignKey(x => x.MemberId);
        }
    }
}
