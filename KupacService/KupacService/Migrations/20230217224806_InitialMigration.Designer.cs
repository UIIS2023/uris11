﻿// <auto-generated />
using System;
using KupacService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KupacService.Migrations
{
    [DbContext(typeof(KupacContext))]
    [Migration("20230217224806_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KupacService.Entities.KupacEntity", b =>
                {
                    b.Property<Guid>("KupacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BrojKupovina")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumPocetkaZabrane")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumZavrsetkaZabrane")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("ImaZabranu")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<Guid>("LiceID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OvlascenoLiceID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prioritet")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KupacID");

                    b.ToTable("Kupci");

                    b.HasData(
                        new
                        {
                            KupacID = new Guid("ccc043c6-398c-485d-9840-092c0441ebe8"),
                            BrojKupovina = 0,
                            DatumPocetkaZabrane = new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumZavrsetkaZabrane = new DateTime(2008, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImaZabranu = true,
                            LiceID = new Guid("334f5277-a71c-4be8-b5da-5c9148b228f7"),
                            OvlascenoLiceID = new Guid("1e24bea9-7df2-4d14-b224-c76fd77536dd"),
                            Prioritet = "VLASNIKSISTEMAZANAVODNJAVANJE"
                        },
                        new
                        {
                            KupacID = new Guid("93d92981-a754-41d8-8d1f-b5462a9e0386"),
                            BrojKupovina = 50,
                            ImaZabranu = false,
                            LiceID = new Guid("92e0d8e9-b221-42a6-9bb8-a80974aee937"),
                            OvlascenoLiceID = new Guid("1e24bea9-7df2-4d14-b224-c76fd77536dd"),
                            Prioritet = "POLJOPRIVREDNIKKOJIJEUPISANUREGISTAR"
                        },
                        new
                        {
                            KupacID = new Guid("4d1c0702-aeb4-4a4f-bdb8-26e1cc53b2eb"),
                            BrojKupovina = 20,
                            ImaZabranu = false,
                            LiceID = new Guid("f127642e-4d73-42f1-979d-6a506aea9bdc"),
                            OvlascenoLiceID = new Guid("904bd8b6-e268-4ca8-89fb-ef2750a74e19"),
                            Prioritet = "VLASNIKSISTEMAZANAVODNJAVANJE"
                        },
                        new
                        {
                            KupacID = new Guid("753d20f5-73a3-4e00-a3a2-e1c43d6b0777"),
                            BrojKupovina = 10,
                            DatumPocetkaZabrane = new DateTime(2005, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DatumZavrsetkaZabrane = new DateTime(2007, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImaZabranu = true,
                            LiceID = new Guid("16e85d49-9cdd-41a6-85bc-180932f68999"),
                            OvlascenoLiceID = new Guid("904bd8b6-e268-4ca8-89fb-ef2750a74e19"),
                            Prioritet = "POLJOPRIVREDNIKKOJIJEUPISANUREGISTAR"
                        },
                        new
                        {
                            KupacID = new Guid("f9e22f42-cd14-4e3b-bbb7-eee4fe30a60a"),
                            BrojKupovina = 30,
                            ImaZabranu = false,
                            LiceID = new Guid("41d2c8bc-0c8c-4fb2-8cf6-2918c33eac9c"),
                            OvlascenoLiceID = new Guid("faea6877-c81e-4829-987e-ea68d5aea752"),
                            Prioritet = "VLASNIKZEMLJISTAKOJEJENAJBLIZEZEMLJISTUKOJESEDAJEUZAKUP"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
