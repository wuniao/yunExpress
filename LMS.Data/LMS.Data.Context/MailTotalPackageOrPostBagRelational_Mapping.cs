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
    
    
    internal partial class MailTotalPackageOrPostBagRelational_Mapping : EntityTypeConfiguration<MailTotalPackageOrPostBagRelational>
    {
        public MailTotalPackageOrPostBagRelational_Mapping()
        {                        
              this.HasKey(t => t.ID);        
              this.ToTable("MailTotalPackageOrPostBagRelationals");
              this.Property(t => t.ID).HasColumnName("ID");
              this.Property(t => t.PostBagNumber).HasColumnName("PostBagNumber").HasMaxLength(20);
              this.Property(t => t.MailTotalPackageNumber).HasColumnName("MailTotalPackageNumber").HasMaxLength(20);
              this.Property(t => t.ScanTime).HasColumnName("ScanTime");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.HasOptional(t => t.MailTotalPackageInfo).WithMany(t => t.MailTotalPackageOrPostBagRelationals).HasForeignKey(d => d.MailTotalPackageNumber);
              this.HasOptional(t => t.MailPostBagInfo).WithMany(t => t.MailTotalPackageOrPostBagRelationals).HasForeignKey(d => d.PostBagNumber);
         }
    }
}
