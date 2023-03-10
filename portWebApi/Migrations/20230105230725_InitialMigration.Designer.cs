// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portWebApi.Data;

#nullable disable

namespace portWebApi.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20230105230725_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("portWebApi.Models.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PostsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostsId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsEnded")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Alt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PostsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostsId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Languages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("StillHere")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Ocupation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ocupations");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Posts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Social", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.SoftSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.TechnicalSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TechnicalSkills");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Trajectory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Visibility")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trajectories");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<Guid>("LanguagesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OcupationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<Guid>("PostsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SocialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SoftSkillsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TechnicalSkillsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TrajectoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkHistoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.WorkHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsEnded")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WorkHistories");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Category", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.Posts", null)
                        .WithMany("Category")
                        .HasForeignKey("PostsId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Education", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("Education")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Image", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.Posts", null)
                        .WithMany("Image")
                        .HasForeignKey("PostsId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Languages", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("Languages")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Location", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("Location")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Ocupation", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("Ocupation")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Posts", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Social", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("Social")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.SoftSkills", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("SoftSkills")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.TechnicalSkills", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("TechnicalSkills")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Trajectory", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("Trajectory")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.WorkHistory", b =>
                {
                    b.HasOne("portWebApi.Models.Domain.User", null)
                        .WithMany("WorkHistory")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.Posts", b =>
                {
                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("portWebApi.Models.Domain.User", b =>
                {
                    b.Navigation("Education");

                    b.Navigation("Languages");

                    b.Navigation("Location");

                    b.Navigation("Ocupation");

                    b.Navigation("Posts");

                    b.Navigation("Social");

                    b.Navigation("SoftSkills");

                    b.Navigation("TechnicalSkills");

                    b.Navigation("Trajectory");

                    b.Navigation("WorkHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
