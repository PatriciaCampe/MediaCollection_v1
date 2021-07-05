﻿// <auto-generated />
using System;
using MediaCollection.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediaCollection.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210614172443_db1")]
    partial class db1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaCollection.Domain.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<int?>("SerieId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("MediaCollection.Domain.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WatchListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("WatchListId");

                    b.ToTable("Media");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Media");
                });

            modelBuilder.Entity("MediaCollection.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId1")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId2")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId3")
                        .HasColumnType("int");

                    b.Property<int?>("MusicId")
                        .HasColumnType("int");

                    b.Property<int?>("MusicId1")
                        .HasColumnType("int");

                    b.Property<int?>("MusicId2")
                        .HasColumnType("int");

                    b.Property<int?>("PodcastId")
                        .HasColumnType("int");

                    b.Property<int?>("PodcastId1")
                        .HasColumnType("int");

                    b.Property<int?>("PodcastId2")
                        .HasColumnType("int");

                    b.Property<int?>("SerieId")
                        .HasColumnType("int");

                    b.Property<int?>("SerieId1")
                        .HasColumnType("int");

                    b.Property<int?>("SerieId2")
                        .HasColumnType("int");

                    b.Property<int?>("SerieId3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("MovieId2");

                    b.HasIndex("MovieId3");

                    b.HasIndex("MusicId");

                    b.HasIndex("MusicId1");

                    b.HasIndex("MusicId2");

                    b.HasIndex("PodcastId");

                    b.HasIndex("PodcastId1");

                    b.HasIndex("PodcastId2");

                    b.HasIndex("SerieId");

                    b.HasIndex("SerieId1");

                    b.HasIndex("SerieId2");

                    b.HasIndex("SerieId3");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("MediaCollection.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MediaCollection.Domain.WatchList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WatchLists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MediaCollection.Domain.Movie", b =>
                {
                    b.HasBaseType("MediaCollection.Domain.Media");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Moviegenres")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Movie");
                });

            modelBuilder.Entity("MediaCollection.Domain.Music", b =>
                {
                    b.HasBaseType("MediaCollection.Domain.Media");

                    b.Property<string>("Lyrics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MusicGenre")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Music");
                });

            modelBuilder.Entity("MediaCollection.Domain.Podcast", b =>
                {
                    b.HasBaseType("MediaCollection.Domain.Media");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Podcast_Description");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Podcast");
                });

            modelBuilder.Entity("MediaCollection.Domain.Serie", b =>
                {
                    b.HasBaseType("MediaCollection.Domain.Media");

                    b.Property<int>("AmountSeasons")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Serie_Description");

                    b.Property<int>("Genre")
                        .HasColumnType("int")
                        .HasColumnName("Serie_Genre");

                    b.HasDiscriminator().HasValue("Serie");
                });

            modelBuilder.Entity("MediaCollection.Domain.Episode", b =>
                {
                    b.HasOne("MediaCollection.Domain.Serie", null)
                        .WithMany("Episodes")
                        .HasForeignKey("SerieId");
                });

            modelBuilder.Entity("MediaCollection.Domain.Media", b =>
                {
                    b.HasOne("MediaCollection.Domain.Person", null)
                        .WithMany("MediaList")
                        .HasForeignKey("PersonId");

                    b.HasOne("MediaCollection.Domain.WatchList", null)
                        .WithMany("MediaList")
                        .HasForeignKey("WatchListId");
                });

            modelBuilder.Entity("MediaCollection.Domain.Person", b =>
                {
                    b.HasOne("MediaCollection.Domain.Movie", null)
                        .WithMany("Actors")
                        .HasForeignKey("MovieId");

                    b.HasOne("MediaCollection.Domain.Movie", null)
                        .WithMany("Directors")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MediaCollection.Domain.Movie", null)
                        .WithMany("Producers")
                        .HasForeignKey("MovieId2");

                    b.HasOne("MediaCollection.Domain.Movie", null)
                        .WithMany("Writers")
                        .HasForeignKey("MovieId3");

                    b.HasOne("MediaCollection.Domain.Music", null)
                        .WithMany("Artists")
                        .HasForeignKey("MusicId");

                    b.HasOne("MediaCollection.Domain.Music", null)
                        .WithMany("Producers")
                        .HasForeignKey("MusicId1");

                    b.HasOne("MediaCollection.Domain.Music", null)
                        .WithMany("Writers")
                        .HasForeignKey("MusicId2");

                    b.HasOne("MediaCollection.Domain.Podcast", null)
                        .WithMany("Hosts")
                        .HasForeignKey("PodcastId");

                    b.HasOne("MediaCollection.Domain.Podcast", null)
                        .WithMany("Producers")
                        .HasForeignKey("PodcastId1");

                    b.HasOne("MediaCollection.Domain.Podcast", null)
                        .WithMany("Writers")
                        .HasForeignKey("PodcastId2");

                    b.HasOne("MediaCollection.Domain.Serie", null)
                        .WithMany("Actors")
                        .HasForeignKey("SerieId");

                    b.HasOne("MediaCollection.Domain.Serie", null)
                        .WithMany("Directors")
                        .HasForeignKey("SerieId1");

                    b.HasOne("MediaCollection.Domain.Serie", null)
                        .WithMany("Producers")
                        .HasForeignKey("SerieId2");

                    b.HasOne("MediaCollection.Domain.Serie", null)
                        .WithMany("Writers")
                        .HasForeignKey("SerieId3");
                });

            modelBuilder.Entity("MediaCollection.Domain.Review", b =>
                {
                    b.HasOne("MediaCollection.Domain.Media", "Media")
                        .WithMany("Reviews")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Media");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaCollection.Domain.Media", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("MediaCollection.Domain.Person", b =>
                {
                    b.Navigation("MediaList");
                });

            modelBuilder.Entity("MediaCollection.Domain.WatchList", b =>
                {
                    b.Navigation("MediaList");
                });

            modelBuilder.Entity("MediaCollection.Domain.Movie", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Directors");

                    b.Navigation("Producers");

                    b.Navigation("Writers");
                });

            modelBuilder.Entity("MediaCollection.Domain.Music", b =>
                {
                    b.Navigation("Artists");

                    b.Navigation("Producers");

                    b.Navigation("Writers");
                });

            modelBuilder.Entity("MediaCollection.Domain.Podcast", b =>
                {
                    b.Navigation("Hosts");

                    b.Navigation("Producers");

                    b.Navigation("Writers");
                });

            modelBuilder.Entity("MediaCollection.Domain.Serie", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Directors");

                    b.Navigation("Episodes");

                    b.Navigation("Producers");

                    b.Navigation("Writers");
                });
#pragma warning restore 612, 618
        }
    }
}
