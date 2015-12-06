﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.WinForm.Client.Models
{
    public class CustomerModel
    {
        public int CustomerTypeID { get; set; }
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public Guid CustomerID { get; set; }
        public int? PaymentTypeID{ get; set; }
    }
}
