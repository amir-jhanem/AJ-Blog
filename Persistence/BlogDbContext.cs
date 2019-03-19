using System;
using System.Collections.Generic;
using AJ_Blog.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AJ_Blog.Persistence
{
    public class BlogDbContext: DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public BlogDbContext(DbContextOptions<BlogDbContext> options) 
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
          //Seeding Authors
          modelBuilder.Entity<Author>().HasData(new Author{
            Id = 1,
            Name = "Amir Jhanem",
            IsRegistered = false
            });

            //Seeding Posts
            modelBuilder.Entity<Post>().HasData(
              new Post { 
                  Id = 1,
                  Title = "Data Seeding",
                  Subtitle="Model seed data",
                  Body = @"<p class="" style=""box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;"">Data seeding is the process of populating a database with an initial set of data.</p><p style=""box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;"">There are several ways this can be accomplished in EF Core:</p><ul style=""margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;""><li style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Model seed data</li><li style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Manual migration customization</li><li class="" style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Custom initialization logic</li></ul>",
                  ImageUrl = "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672",
                  CreationDate = DateTime.Now,
                  AuthorId = 1
               },
               new Post { 
                  Id = 2,
                  Title = "Data Seeding 2",
                  Subtitle="Model seed data",
                  Body = @"<p class="" style=""box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;"">Data seeding is the process of populating a database with an initial set of data.</p><p style=""box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;"">There are several ways this can be accomplished in EF Core:</p><ul style=""margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;""><li style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Model seed data</li><li style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Manual migration customization</li><li class="" style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Custom initialization logic</li></ul>",
                  ImageUrl = "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672",
                  CreationDate = DateTime.Now,
                  AuthorId = 1
               },
               new Post { 
                  Id = 3,
                  Title = "Data Seeding 3",
                  Subtitle="Model seed data",
                  Body = @"<p class="" style=""box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;"">Data seeding is the process of populating a database with an initial set of data.</p><p style=""box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;"">There are several ways this can be accomplished in EF Core:</p><ul style=""margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;""><li style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Model seed data</li><li style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Manual migration customization</li><li class="" style=""outline: 0px; box-sizing: inherit; list-style: disc outside none;"">Custom initialization logic</li></ul>",
                  ImageUrl = "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672",
                  CreationDate = DateTime.Now,
                  AuthorId = 1
               });
            
        }
    }
}