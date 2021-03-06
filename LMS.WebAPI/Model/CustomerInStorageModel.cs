﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.WebAPI.Model
{
    public class CustomerInStorageModel
    {
        public string CustomerCode { get; set; }
        public string AccountID { get; set; }
        public Nullable<int> CustomerTypeID { get; set; }
        public string Name { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public string PaymentTypeName { get; set; }
        public decimal Balance { get; set; }
    }
}