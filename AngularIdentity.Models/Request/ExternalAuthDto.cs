﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularIdentity.Models.Request
{
    public class ExternalAuthDto
    {
        public string? Provider {  get; set; }
        public string? IdToken { get; set; }
    }
}
