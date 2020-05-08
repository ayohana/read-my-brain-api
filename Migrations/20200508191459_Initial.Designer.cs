﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadMyBrainAPI.Models;

namespace read_my_brain_api.Migrations
{
    [DbContext(typeof(ReadMyBrainAPIContext))]
    [Migration("20200508191459_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ReadMyBrainAPI.Models.Term", b =>
                {
                    b.Property<int>("TermID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("TermID");

                    b.ToTable("Terms");

                    b.HasData(
                        new
                        {
                            TermID = 1,
                            Definition = "Male",
                            Name = "M"
                        },
                        new
                        {
                            TermID = 2,
                            Definition = "Female",
                            Name = "F"
                        },
                        new
                        {
                            TermID = 3,
                            Definition = "History of",
                            Name = "Hx"
                        },
                        new
                        {
                            TermID = 4,
                            Definition = "history of",
                            Name = "hx"
                        },
                        new
                        {
                            TermID = 5,
                            Definition = "Allergy of",
                            Name = "Ax"
                        },
                        new
                        {
                            TermID = 6,
                            Definition = "Do Not Resuscitate",
                            Name = "DNR"
                        },
                        new
                        {
                            TermID = 7,
                            Definition = "Do Not Resuscitate",
                            Name = "dnr"
                        },
                        new
                        {
                            TermID = 8,
                            Definition = "patient",
                            Name = "pt"
                        },
                        new
                        {
                            TermID = 9,
                            Definition = "patient",
                            Name = "Pt"
                        },
                        new
                        {
                            TermID = 10,
                            Definition = "Physical Therapist",
                            Name = "PT"
                        },
                        new
                        {
                            TermID = 11,
                            Definition = "with",
                            Name = "c̅"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
