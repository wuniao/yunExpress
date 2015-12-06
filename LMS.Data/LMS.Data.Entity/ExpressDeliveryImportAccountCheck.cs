//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class ExpressDeliveryImportAccountCheck : Entity
    {
        public virtual int ExpressDeliveryImportAccountCheckID { get; set; }
        public virtual string OrderNumber { get; set; }
        public virtual string UserName { get; set; }
        public virtual string WayBillNumber { get; set; }
        public virtual Nullable<System.DateTime> ReceivingDate { get; set; }
        public virtual string VenderName { get; set; }
        public virtual string ShippingMethodName { get; set; }
        public virtual string CountryName { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual Nullable<decimal> SettleWeight { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal FuelCharge { get; set; }
        public virtual decimal Register { get; set; }
        public virtual decimal Surcharge { get; set; }
        public virtual decimal TariffPrepayFee { get; set; }
        public virtual decimal OverWeightLengthGirthFee { get; set; }
        public virtual decimal SecurityAppendFee { get; set; }
        public virtual decimal AddedTaxFee { get; set; }
        public virtual decimal Incidentals { get; set; }
        public virtual string IncidentalRemark { get; set; }
        public virtual decimal TotalFee { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual int Status { get; set; }
    }
}
