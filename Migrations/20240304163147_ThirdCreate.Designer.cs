﻿// <auto-generated />
using System;
using CardWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardWebsite.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20240304163147_ThirdCreate")]
    partial class ThirdCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("CardWebsite.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("CardWebsite.Models.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DeckId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GradeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CollectionId");

                    b.HasIndex("CardId");

                    b.HasIndex("DeckId");

                    b.HasIndex("GradeId");

                    b.HasIndex("SetId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("CardWebsite.Models.Deck", b =>
                {
                    b.Property<int>("DeckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeckId");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("CardWebsite.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("CardWebsite.Models.Set", b =>
                {
                    b.Property<int>("SetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SetId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("CardWebsite.Models.Collection", b =>
                {
                    b.HasOne("CardWebsite.Models.Card", "Card")
                        .WithMany("Collections")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CardWebsite.Models.Deck", null)
                        .WithMany("Collections")
                        .HasForeignKey("DeckId");

                    b.HasOne("CardWebsite.Models.Grade", null)
                        .WithMany("Collections")
                        .HasForeignKey("GradeId");

                    b.HasOne("CardWebsite.Models.Set", "Set")
                        .WithMany("Collections")
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Set");
                });

            modelBuilder.Entity("CardWebsite.Models.Card", b =>
                {
                    b.Navigation("Collections");
                });

            modelBuilder.Entity("CardWebsite.Models.Deck", b =>
                {
                    b.Navigation("Collections");
                });

            modelBuilder.Entity("CardWebsite.Models.Grade", b =>
                {
                    b.Navigation("Collections");
                });

            modelBuilder.Entity("CardWebsite.Models.Set", b =>
                {
                    b.Navigation("Collections");
                });
#pragma warning restore 612, 618
        }
    }
}
