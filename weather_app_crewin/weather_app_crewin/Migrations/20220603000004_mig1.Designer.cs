﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using weather_app_crewin.Models;

namespace weather_app_crewin.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220603000004_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("weather_app_crewin.Models.weather_info", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("city_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperature")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("weather_infos");
                });
#pragma warning restore 612, 618
        }
    }
}
