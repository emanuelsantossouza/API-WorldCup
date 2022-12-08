﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldCupAPI.Data;

#nullable disable

namespace WorldCupAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WorldCupAPI.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Flag")
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Flag = "https://flagpedia.net/data/flags/w580/qa.webp",
                            Name = "Qatar"
                        },
                        new
                        {
                            Id = 2,
                            Flag = "https://flagpedia.net/data/flags/w580/ec.webp",
                            Name = "Equador"
                        },
                        new
                        {
                            Id = 3,
                            Flag = "https://flagpedia.net/data/flags/w580/sn.webp",
                            Name = "Senegal"
                        },
                        new
                        {
                            Id = 4,
                            Flag = "https://flagpedia.net/data/flags/w580/nl.png",
                            Name = "Holanda"
                        },
                        new
                        {
                            Id = 5,
                            Flag = "https://flagpedia.net/data/flags/w580/gb-eng.png",
                            Name = "Inglaterra"
                        },
                        new
                        {
                            Id = 6,
                            Flag = "https://flagpedia.net/data/flags/w580/ir.webp",
                            Name = "Irã"
                        },
                        new
                        {
                            Id = 7,
                            Flag = "https://flagpedia.net/data/flags/w580/us.webp",
                            Name = "EUA"
                        },
                        new
                        {
                            Id = 8,
                            Flag = "https://flagpedia.net/data/flags/w580/gb-wls.webp",
                            Name = "País de Gales"
                        },
                        new
                        {
                            Id = 9,
                            Flag = "https://flagpedia.net/data/flags/w580/ar.webp",
                            Name = "Argentina"
                        },
                        new
                        {
                            Id = 10,
                            Flag = "https://flagpedia.net/data/flags/w580/sa.webp",
                            Name = "Arábia Saudita"
                        },
                        new
                        {
                            Id = 11,
                            Flag = "https://flagpedia.net/data/flags/w580/mx.webp",
                            Name = "México"
                        },
                        new
                        {
                            Id = 12,
                            Flag = "https://flagpedia.net/data/flags/w580/pl.png",
                            Name = "Polônia"
                        },
                        new
                        {
                            Id = 13,
                            Flag = "https://flagpedia.net/data/flags/w580/fr.png",
                            Name = "França"
                        },
                        new
                        {
                            Id = 14,
                            Flag = "https://flagpedia.net/data/flags/w580/au.webp",
                            Name = "Austrália"
                        },
                        new
                        {
                            Id = 15,
                            Flag = "https://flagpedia.net/data/flags/w580/dk.webp",
                            Name = "Dinamarca"
                        },
                        new
                        {
                            Id = 16,
                            Flag = "https://flagpedia.net/data/flags/w580/tn.webp",
                            Name = "Tunísia"
                        },
                        new
                        {
                            Id = 17,
                            Flag = "https://flagpedia.net/data/flags/w580/es.webp",
                            Name = "Espanha"
                        },
                        new
                        {
                            Id = 18,
                            Flag = "https://flagpedia.net/data/flags/w580/cr.webp",
                            Name = "Costa Rica"
                        },
                        new
                        {
                            Id = 19,
                            Flag = "https://flagpedia.net/data/flags/w580/de.png",
                            Name = "Alemanha"
                        },
                        new
                        {
                            Id = 20,
                            Flag = "https://flagpedia.net/data/flags/w580/jp.webp",
                            Name = "Japão"
                        },
                        new
                        {
                            Id = 21,
                            Flag = "https://flagpedia.net/data/flags/w580/be.png",
                            Name = "Bélgica"
                        },
                        new
                        {
                            Id = 22,
                            Flag = "https://flagpedia.net/data/flags/w580/ca.webp",
                            Name = "Canadá"
                        },
                        new
                        {
                            Id = 23,
                            Flag = "https://flagpedia.net/data/flags/w580/ma.webp",
                            Name = "Marrocos"
                        },
                        new
                        {
                            Id = 24,
                            Flag = "https://flagpedia.net/data/flags/w580/hr.webp",
                            Name = "Croácia"
                        },
                        new
                        {
                            Id = 25,
                            Flag = "https://flagpedia.net/data/flags/w580/br.webp",
                            Name = "Brasil"
                        },
                        new
                        {
                            Id = 26,
                            Flag = "https://flagpedia.net/data/flags/w580/rs.webp",
                            Name = "Sérvia"
                        },
                        new
                        {
                            Id = 27,
                            Flag = "https://flagpedia.net/data/flags/w580/ch.png",
                            Name = "Suíça"
                        },
                        new
                        {
                            Id = 28,
                            Flag = "https://flagpedia.net/data/flags/w580/cm.webp",
                            Name = "Camarões"
                        },
                        new
                        {
                            Id = 29,
                            Flag = "https://flagpedia.net/data/flags/w580/pt.webp",
                            Name = "Portugal"
                        },
                        new
                        {
                            Id = 30,
                            Flag = "https://flagpedia.net/data/flags/w580/gh.webp",
                            Name = "Gana"
                        },
                        new
                        {
                            Id = 31,
                            Flag = "https://flagpedia.net/data/flags/w580/uy.webp",
                            Name = "Uruguai"
                        },
                        new
                        {
                            Id = 32,
                            Flag = "https://flagpedia.net/data/flags/w580/kr.webp",
                            Name = "Coreia do Sul"
                        });
                });

            modelBuilder.Entity("WorldCupAPI.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<ushort>("Year")
                        .HasColumnType("smallint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("WorldCup");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Year = (ushort)2022
                        });
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCupCountry", b =>
                {
                    b.Property<int>("WorldCupId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)");

                    b.HasKey("WorldCupId", "CountryId");

                    b.HasIndex("CountryId");

                    b.ToTable("WorldCupCountry");

                    b.HasData(
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 1,
                            Group = "A"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 2,
                            Group = "A"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 3,
                            Group = "A"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 4,
                            Group = "A"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 5,
                            Group = "B"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 6,
                            Group = "B"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 7,
                            Group = "B"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 8,
                            Group = "B"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 9,
                            Group = "C"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 10,
                            Group = "C"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 11,
                            Group = "C"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 12,
                            Group = "C"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 13,
                            Group = "D"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 14,
                            Group = "D"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 15,
                            Group = "D"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 16,
                            Group = "D"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 17,
                            Group = "E"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 18,
                            Group = "E"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 19,
                            Group = "E"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 20,
                            Group = "E"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 21,
                            Group = "F"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 22,
                            Group = "F"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 23,
                            Group = "F"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 24,
                            Group = "F"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 25,
                            Group = "G"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 26,
                            Group = "G"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 27,
                            Group = "G"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 28,
                            Group = "G"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 29,
                            Group = "H"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 30,
                            Group = "H"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 31,
                            Group = "H"
                        },
                        new
                        {
                            WorldCupId = 1,
                            CountryId = 32,
                            Group = "H"
                        });
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCupCountryPlayer", b =>
                {
                    b.Property<int>("WorldCupId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("PlayerId")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.HasKey("WorldCupId", "CountryId", "PlayerId");

                    b.HasIndex("CountryId");

                    b.HasIndex("PlayerId");

                    b.ToTable("WorldCupCountryPlayer");
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCup", b =>
                {
                    b.HasOne("WorldCupAPI.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCupCountry", b =>
                {
                    b.HasOne("WorldCupAPI.Models.Country", "Country")
                        .WithMany("WorldCups")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorldCupAPI.Models.WorldCup", "WorldCup")
                        .WithMany("Countries")
                        .HasForeignKey("WorldCupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("WorldCup");
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCupCountryPlayer", b =>
                {
                    b.HasOne("WorldCupAPI.Models.Country", "Country")
                        .WithMany("WorldCupPlayers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorldCupAPI.Models.Player", "Player")
                        .WithMany("WorldCupPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorldCupAPI.Models.WorldCup", "WorldCup")
                        .WithMany("WorldCupPlayers")
                        .HasForeignKey("WorldCupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Player");

                    b.Navigation("WorldCup");
                });

            modelBuilder.Entity("WorldCupAPI.Models.Country", b =>
                {
                    b.Navigation("WorldCupPlayers");

                    b.Navigation("WorldCups");
                });

            modelBuilder.Entity("WorldCupAPI.Models.Player", b =>
                {
                    b.Navigation("WorldCupPlayers");
                });

            modelBuilder.Entity("WorldCupAPI.Models.WorldCup", b =>
                {
                    b.Navigation("Countries");

                    b.Navigation("WorldCupPlayers");
                });
#pragma warning restore 612, 618
        }
    }
}
