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
    
    
    internal partial class Article_Mapping : EntityTypeConfiguration<Article>
    {
        public Article_Mapping()
        {                        
              this.HasKey(t => t.ArticleID);        
              this.ToTable("Article");
              this.Property(t => t.ArticleID).HasColumnName("ArticleID");
              this.Property(t => t.CategoryID).HasColumnName("CategoryID");
              this.Property(t => t.Title).HasColumnName("Title").HasMaxLength(500);
              this.Property(t => t.Detail).HasColumnName("Detail");
              this.Property(t => t.Source).HasColumnName("Source").HasMaxLength(50);
              this.Property(t => t.Author).HasColumnName("Author").HasMaxLength(50);
              this.Property(t => t.PublishedTime).HasColumnName("PublishedTime");
              this.Property(t => t.Pic).HasColumnName("Pic").HasMaxLength(500);
              this.Property(t => t.Sort).HasColumnName("Sort");
              this.Property(t => t.SeoTitle).HasColumnName("SeoTitle");
              this.Property(t => t.SeoKeywords).HasColumnName("SeoKeywords");
              this.Property(t => t.SeoDescription).HasColumnName("SeoDescription");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.Status).HasColumnName("Status");
              this.HasRequired(t => t.Category).WithMany(t => t.Articles).HasForeignKey(d => d.CategoryID);
         }
    }
}
