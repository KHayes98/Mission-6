﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_6.Models;

namespace Mission_6.Migrations
{
    [DbContext(typeof(MovieDatabaseContext))]
    partial class MovieDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mission_6.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission_6.Models.MovieForm", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "J.J. Abrams",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Star Trek (2009)",
                            Year = (short)2009
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 1,
                            Director = "George Lucus",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Star Wars: Revenge of the Sith",
                            Year = (short)2005
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 1,
                            Director = "Joe & Anthony Russo",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Captain America: The Winter Soldier",
                            Year = (short)2014
                        });
                });

            modelBuilder.Entity("Mission_6.Models.MovieForm", b =>
                {
                    b.HasOne("Mission_6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
