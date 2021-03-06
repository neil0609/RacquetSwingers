﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RacquetSwingers.Entities;
using System;

namespace RacquetSwingers.Migrations
{
    [DbContext(typeof(RacquetSwingersDbContext))]
    partial class RacquetSwingersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RacquetSwingers.Models.Domain.RacquetSwingersDomain", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Court");

                    b.Property<DateTime>("Time");

                    b.HasKey("ID");

                    b.ToTable("RacquetSwinger");
                });
#pragma warning restore 612, 618
        }
    }
}
