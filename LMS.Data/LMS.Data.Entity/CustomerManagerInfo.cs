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
    
    public partial class CustomerManagerInfo : Entity
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string EnName { get; set; }
        public virtual string DepartmentName { get; set; }
        public virtual Nullable<bool> Sex { get; set; }
        public virtual string Tel { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string EMail { get; set; }
        public virtual int Status { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
    }
}
