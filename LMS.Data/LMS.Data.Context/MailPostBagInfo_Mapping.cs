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
    
    
    internal partial class MailPostBagInfo_Mapping : EntityTypeConfiguration<MailPostBagInfo>
    {
        public MailPostBagInfo_Mapping()
        {                        
              this.HasKey(t => t.PostBagNumber);        
              this.ToTable("MailPostBagInfos");
              this.Property(t => t.PostBagNumber).HasColumnName("PostBagNumber").IsRequired().HasMaxLength(20);
              this.Property(t => t.OutStorageID).HasColumnName("OutStorageID").IsRequired().HasMaxLength(16);
              this.Property(t => t.CountryCode).HasColumnName("CountryCode").IsRequired().HasMaxLength(5);
              this.Property(t => t.IsBattery).HasColumnName("IsBattery");
              this.Property(t => t.FuPostBagNumber).HasColumnName("FuPostBagNumber").HasMaxLength(35);
              this.Property(t => t.ScanTime).HasColumnName("ScanTime");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.Property(t => t.TrackStatus).HasColumnName("TrackStatus");
              this.Property(t => t.TotalWeight).HasColumnName("TotalWeight");
              this.Property(t => t.ScanBy).HasColumnName("ScanBy").HasMaxLength(50);
              this.HasRequired(t => t.OutStorageInfo).WithMany(t => t.MailPostBagInfos).HasForeignKey(d => d.OutStorageID);
         }
    }
}
