// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DotNetNukeBlogs.Data.Models
{
    public partial class BlogTags
    {
        public BlogTags()
        {
            BlogEntryTags = new HashSet<BlogEntryTags>();
        }

        public int TagId { get; set; }
        public string Tag { get; set; }
        public string Slug { get; set; }
        public bool Active { get; set; }
        public int PortalId { get; set; }

        public virtual ICollection<BlogEntryTags> BlogEntryTags { get; set; }
    }
}