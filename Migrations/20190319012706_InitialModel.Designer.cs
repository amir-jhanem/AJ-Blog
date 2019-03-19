﻿// <auto-generated />
using System;
using AJ_Blog.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace aj_blog.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20190319012706_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AJ_Blog.Core.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsRegistered");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsRegistered = false,
                            Name = "Amir Jhanem"
                        });
                });

            modelBuilder.Entity("AJ_Blog.Core.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Body = "<p class=\" style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">Data seeding is the process of populating a database with an initial set of data.</p><p style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">There are several ways this can be accomplished in EF Core:</p><ul style=\"margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\"><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Model seed data</li><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Manual migration customization</li><li class=\" style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Custom initialization logic</li></ul>",
                            CreationDate = new DateTime(2019, 3, 19, 3, 27, 5, 993, DateTimeKind.Local).AddTicks(4309),
                            ImageUrl = "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672",
                            Subtitle = "Model seed data",
                            Title = "Data Seeding"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Body = "<p class=\" style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">Data seeding is the process of populating a database with an initial set of data.</p><p style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">There are several ways this can be accomplished in EF Core:</p><ul style=\"margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\"><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Model seed data</li><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Manual migration customization</li><li class=\" style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Custom initialization logic</li></ul>",
                            CreationDate = new DateTime(2019, 3, 19, 3, 27, 5, 994, DateTimeKind.Local).AddTicks(9796),
                            ImageUrl = "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672",
                            Subtitle = "Model seed data",
                            Title = "Data Seeding 2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Body = "<p class=\" style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">Data seeding is the process of populating a database with an initial set of data.</p><p style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">There are several ways this can be accomplished in EF Core:</p><ul style=\"margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\"><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Model seed data</li><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Manual migration customization</li><li class=\" style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Custom initialization logic</li></ul>",
                            CreationDate = new DateTime(2019, 3, 19, 3, 27, 5, 994, DateTimeKind.Local).AddTicks(9816),
                            ImageUrl = "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672",
                            Subtitle = "Model seed data",
                            Title = "Data Seeding 3"
                        });
                });

            modelBuilder.Entity("AJ_Blog.Core.Models.Post", b =>
                {
                    b.HasOne("AJ_Blog.Core.Models.Author", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
