﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LighTake.Infrastructure.Seedwork;

namespace LMS.Data.Entity
{
    public class CustomerCreditParam : SearchParam
    {
        public string CustomerCode { get; set; }
        public int? Status { get; set; }
    }
}
