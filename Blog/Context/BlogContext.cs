using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Blogg> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}