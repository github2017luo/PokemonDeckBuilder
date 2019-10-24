﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PTCGUltraFanClub.Models;

namespace PTCGUltraFanClub.Migrations
{
    [DbContext(typeof(PTCGUltraFanClubContext))]
    [Migration("20191024174615_AddUserToDbTables")]
    partial class AddUserToDbTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PTCGUltraFanClub.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("EmailAddresss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userDeckChoicesID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("userDeckChoicesID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PTCGUltraFanClub.Models.UserDeckChoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeckChoice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UserDeckChoices");
                });

            modelBuilder.Entity("PTCGUltraFanClub.Models.User", b =>
                {
                    b.HasOne("PTCGUltraFanClub.Models.UserDeckChoice", "userDeckChoices")
                        .WithMany()
                        .HasForeignKey("userDeckChoicesID");
                });
#pragma warning restore 612, 618
        }
    }
}
