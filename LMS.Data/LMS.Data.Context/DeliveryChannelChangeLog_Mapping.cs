//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class DeliveryChannelChangeLog_Mapping : EntityTypeConfiguration<DeliveryChannelChangeLog>
    {
        public DeliveryChannelChangeLog_Mapping()
        {                        
              this.HasKey(t => t.WayBillNumber);        
              this.ToTable("DeliveryChannelChangeLogs");
              this.Property(t => t.WayBillNumber).HasColumnName("WayBillNumber").IsRequired().HasMaxLength(20);
              this.Property(t => t.ShippingMethodId).HasColumnName("ShippingMethodId");
              this.Property(t => t.VenderCode).HasColumnName("VenderCode").IsRequired().HasMaxLength(50);
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
         }
    }
}
