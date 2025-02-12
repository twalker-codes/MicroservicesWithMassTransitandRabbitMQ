﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newsletter.Api.Database;

#nullable disable

namespace Newsletter.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Newsletter.Api.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PublishedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Newsletter.Api.Entities.Article", b =>
                {
                    b.OwnsOne("System.Collections.Generic.List<Newsletter.Api.Entities.Tag>", "Tags", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Capacity")
                                .HasColumnType("int");

                            b1.HasKey("ArticleId");

                            b1.ToTable("Articles");

                            b1.ToJson("Tags");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.Navigation("Tags")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
