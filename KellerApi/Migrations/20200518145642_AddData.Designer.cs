﻿// <auto-generated />
using KellerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KellerApi.Migrations
{
    [DbContext(typeof(KellerDbContext))]
    [Migration("20200518145642_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KellerApi.Data.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Quest")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa culpa ea suscipit animi, reprehenderit incidunt nostrum voluptas, nihil ipsum quaerat, dolore magni veritatis aliquid? Illo delectus eligendi ullam nobis sint ad possimus! Expedita id asperiores veniam sunt dolores corrupti, quam odit blanditiis est enim distinctio quidem ut dignissimos, vel harum?",
                            Quest = "Q. Dummy text lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ipsa culpa ea suscipit animi, reprehenderit incidunt nostrum voluptas, nihil ipsum quaerat, dolore magni veritatis aliquid? Illo delectus eligendi ullam nobis sint ad possimus! Expedita id asperiores veniam sunt dolores corrupti, quam odit blanditiis est enim distinctio quidem ut dignissimos, vel harum?",
                            Quest = "Q. Dummy text lorem ipsum dolor sit amet"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}