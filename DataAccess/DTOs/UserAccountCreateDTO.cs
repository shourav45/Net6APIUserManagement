﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class UserAccountCreateDTO
    {
        public int ProfileId { get; set; }
        public string? UserPassword { get; set; }
       
    }
}
