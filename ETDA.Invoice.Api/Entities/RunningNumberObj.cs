﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETDA.Invoice.Api.Entities
{
    public class RunningNumberObj
    {
        public int id { get; set; }
        public string prefix { get; set; }
        public string number { get; set; }
    }
}
