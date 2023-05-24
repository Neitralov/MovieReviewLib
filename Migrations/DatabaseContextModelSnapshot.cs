﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieReviewLib.Data;

#nullable disable

namespace MovieReviewLib.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("MovieReviewLib.Data.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Compositor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Compositor");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Duration")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Score")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WatchLater")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Writer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Writer");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Actor", b =>
                {
                    b.HasOne("MovieReviewLib.Data.Movie", null)
                        .WithMany("Actors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Compositor", b =>
                {
                    b.HasOne("MovieReviewLib.Data.Movie", null)
                        .WithMany("Compositors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Director", b =>
                {
                    b.HasOne("MovieReviewLib.Data.Movie", null)
                        .WithMany("Directors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Genre", b =>
                {
                    b.HasOne("MovieReviewLib.Data.Movie", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Producer", b =>
                {
                    b.HasOne("MovieReviewLib.Data.Movie", null)
                        .WithMany("Producers")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Writer", b =>
                {
                    b.HasOne("MovieReviewLib.Data.Movie", null)
                        .WithMany("Writers")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieReviewLib.Data.Movie", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Compositors");

                    b.Navigation("Directors");

                    b.Navigation("Genres");

                    b.Navigation("Producers");

                    b.Navigation("Writers");
                });
#pragma warning restore 612, 618
        }
    }
}
