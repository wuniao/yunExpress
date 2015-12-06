﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.WebAPI.Model
{
    public class InStorageSaveModel
    {
        public InStorageSaveModel()
        {
            WayBillInfoSaveList = new List<WayBillInfoSaveModel>();
        }

        public List<WayBillInfoSaveModel> WayBillInfoSaveList { get; set; }

        public int CustomerType { get; set; }
        public string CustomerCode { get; set; }
        public string OperatorUserName { get; set; }
        public DateTime ReceivingDate { get; set; }
    }
}