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
    
    
    internal partial class WayBillPrintLog_Mapping : EntityTypeConfiguration<WayBillPrintLog>
    {
        public WayBillPrintLog_Mapping()
        {                        
              this.HasKey(t => t.logID);        
              this.ToTable("WayBillPrintLog");
              this.Property(t => t.logID).HasColumnName("logID");
              this.Property(t => t.waybillnumber).HasColumnName("waybillnumber").IsRequired().HasMaxLength(50);
              this.Property(t => t.sendGoodsVender).HasColumnName("sendGoodsVender").IsRequired().HasMaxLength(1000);
              this.Property(t => t.sendGoodsChannel).HasColumnName("sendGoodsChannel").IsRequired().HasMaxLength(50);
              this.Property(t => t.newTrackNumber).HasColumnName("newTrackNumber").IsRequired().HasMaxLength(50);
              this.Property(t => t.printPerson).HasColumnName("printPerson").IsRequired().HasMaxLength(50);
              this.Property(t => t.printDate).HasColumnName("printDate");
         }
    }
}
