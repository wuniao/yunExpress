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
    
    public partial class WayBillTemplate : Entity
    {
        public virtual int WayBillTemplateId { get; set; }
        public virtual string TemplateName { get; set; }
        public virtual string TemplateTypeId { get; set; }
        public virtual int ShippingMethodId { get; set; }
        public virtual int Status { get; set; }
        public virtual string TemplateContent { get; set; }
        public virtual string Remark { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual int RowNumber { get; set; }
        public virtual int ColumnNumber { get; set; }
        public virtual int TemplateHeadId { get; set; }
        public virtual int TemplateContentId { get; set; }
        public virtual int LinkMode { get; set; }
        public virtual string Countries { get; set; }
    }
}
