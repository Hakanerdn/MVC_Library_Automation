﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class RoleGuide
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}
