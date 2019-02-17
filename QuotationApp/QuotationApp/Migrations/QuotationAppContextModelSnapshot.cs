﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuotationApp.Models;

namespace QuotationApp.Migrations
{
    [DbContext(typeof(QuotationAppContext))]
    partial class QuotationAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuotationApp.Models.EventQuotation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colors");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Details");

                    b.Property<bool>("FullPackage");

                    b.Property<int>("NumberOfPeople");

                    b.Property<string>("Tematic");

                    b.Property<string>("Type");

                    b.Property<DateTime>("hour");

                    b.HasKey("Id");

                    b.ToTable("EventQuotation");
                });
#pragma warning restore 612, 618
        }
    }
}
