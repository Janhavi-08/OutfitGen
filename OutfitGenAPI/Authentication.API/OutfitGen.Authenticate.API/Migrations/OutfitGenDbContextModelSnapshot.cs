﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutfitGen.Authenticate.API.data;

#nullable disable

namespace OutfitGen.Authenticate.API.Migrations
{
    [DbContext(typeof(OutfitGenDbContext))]
    partial class OutfitGenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.ClothingItem", b =>
                {
                    b.Property<int>("ClothingItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClothingItemId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClothingItemId");

                    b.HasIndex("UserId");

                    b.ToTable("ClothingItems");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.ClothingItemTag", b =>
                {
                    b.Property<int>("ClothingItemId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ClothingItemId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("clothingItemTags");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Userid"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Userid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.ClothingItem", b =>
                {
                    b.HasOne("OutfitGen.Authenticate.API.Models.User", "User")
                        .WithMany("ClothingItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.ClothingItemTag", b =>
                {
                    b.HasOne("OutfitGen.Authenticate.API.Models.ClothingItem", "ClothingItem")
                        .WithMany("ClothingItemTags")
                        .HasForeignKey("ClothingItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutfitGen.Authenticate.API.Models.Tag", "Tag")
                        .WithMany("ClothingItemTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClothingItem");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.ClothingItem", b =>
                {
                    b.Navigation("ClothingItemTags");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.Tag", b =>
                {
                    b.Navigation("ClothingItemTags");
                });

            modelBuilder.Entity("OutfitGen.Authenticate.API.Models.User", b =>
                {
                    b.Navigation("ClothingItems");
                });
#pragma warning restore 612, 618
        }
    }
}
