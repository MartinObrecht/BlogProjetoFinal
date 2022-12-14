// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BlazorBlogs.Data.Models
{
    public partial class Blogs
    {
        public Blogs()
        {
            BlogCategory = new HashSet<BlogCategory>();
            Comment = new HashSet<Comment>();
        }

        public int BlogId { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogTitle { get; set; }
        public string BlogSummary { get; set; }
        public string BlogContent { get; set; }
        public string BlogUserName { get; set; }

        public virtual ICollection<BlogCategory> BlogCategory { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}