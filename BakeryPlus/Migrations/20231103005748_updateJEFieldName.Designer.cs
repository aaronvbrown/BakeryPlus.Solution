﻿// <auto-generated />
using BakeryPlus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BakeryPlus.Migrations
{
    [DbContext(typeof(BakeryPlusContext))]
    [Migration("20231103005748_updateJEFieldName")]
    partial class updateJEFieldName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BakeryPlus.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("BakeryPlus.Models.Treat", b =>
                {
                    b.Property<int>("TreatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TreatId");

                    b.ToTable("Treats");
                });

            modelBuilder.Entity("BakeryPlus.Models.TreatFlavor", b =>
                {
                    b.Property<int>("TreatFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FlavorId")
                        .HasColumnType("int");

                    b.Property<int>("TreatId")
                        .HasColumnType("int");

                    b.HasKey("TreatFlavorId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("TreatId");

                    b.ToTable("TreatFlavors");
                });

            modelBuilder.Entity("BakeryPlus.Models.TreatFlavor", b =>
                {
                    b.HasOne("BakeryPlus.Models.Flavor", "flavor")
                        .WithMany("JoinEntities")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BakeryPlus.Models.Treat", "Treat")
                        .WithMany("JoinEntities")
                        .HasForeignKey("TreatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Treat");

                    b.Navigation("flavor");
                });

            modelBuilder.Entity("BakeryPlus.Models.Flavor", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("BakeryPlus.Models.Treat", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
