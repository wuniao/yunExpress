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
    
    public partial class SystemConfiguration : Entity
    {
        public virtual System.Guid DictionaryID { get; set; }
        public virtual int ConfigurationTypeID { get; set; }
        public virtual string ConfigurationKey { get; set; }
        public virtual string ConfigurationValue { get; set; }
        public virtual bool IsEnable { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
    }
}
