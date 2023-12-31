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
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.ToTable("UserRole");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(x=>x.User).WithMany(x=>x.UserRole).HasForeignKey(x=>x.UserId);
            this.HasRequired(x => x.RoleGuide).WithMany(x => x.UserRole).HasForeignKey(x => x.RoleId);
        }
    }
}
