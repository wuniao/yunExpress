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
    
    public partial class Article : Entity
    {
        public virtual int ArticleID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Detail { get; set; }
        public virtual string Source { get; set; }
        public virtual string Author { get; set; }
        public virtual Nullable<System.DateTime> PublishedTime { get; set; }
        public virtual string Pic { get; set; }
        public virtual int Sort { get; set; }
        public virtual string SeoTitle { get; set; }
        public virtual string SeoKeywords { get; set; }
        public virtual string SeoDescription { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual Nullable<System.DateTime> CreatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual Nullable<System.DateTime> LastUpdatedOn { get; set; }
        public virtual Nullable<int> Status { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
