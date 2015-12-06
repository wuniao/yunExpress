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
    
    
    internal partial class JobErrorLog_Mapping : EntityTypeConfiguration<JobErrorLog>
    {
        public JobErrorLog_Mapping()
        {                        
              this.HasKey(t => t.JobErrorLogID);        
              this.ToTable("JobErrorLogs");
              this.Property(t => t.JobErrorLogID).HasColumnName("JobErrorLogID");
              this.Property(t => t.WayBillNumber).HasColumnName("WayBillNumber").HasMaxLength(20);
              this.Property(t => t.JobType).HasColumnName("JobType");
              this.Property(t => t.ErrorType).HasColumnName("ErrorType");
              this.Property(t => t.ErrorBody).HasColumnName("ErrorBody");
              this.Property(t => t.IsCorrect).HasColumnName("IsCorrect");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.HasOptional(t => t.WayBillInfo).WithMany(t => t.JobErrorLogs).HasForeignKey(d => d.WayBillNumber);
         }
    }
}
