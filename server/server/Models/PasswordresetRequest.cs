﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PasswordresetRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public System.DateTime Created { get; set; }
    }
}
