using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Test.Models;

namespace Test.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20200811125046_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryName");

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Test.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("id");

                    b.HasIndex("CountryId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Test.Models.Customer", b =>
                {
                    b.HasOne("Test.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });
        }
    }
}
