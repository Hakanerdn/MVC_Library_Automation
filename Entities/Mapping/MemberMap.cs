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
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            this.ToTable("Member");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.NameSurname).IsRequired().HasMaxLength(100);
            this.Property(x => x.Email).IsRequired().HasMaxLength(150);
            this.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            this.Property(x => x.Address).IsRequired().HasMaxLength(500);
        }
    }
}
