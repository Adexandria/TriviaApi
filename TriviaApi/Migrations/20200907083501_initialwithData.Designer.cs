﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriviaApi.Service;

namespace TriviaApi.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20200907083501_initialwithData")]
    partial class initialwithData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TriviaApi.Entities.Trivia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trivias");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95a"),
                            Answers = "Brown",
                            Category = 6,
                            Difficulty = 0,
                            Questions = "What is the rarest M&M color?"
                        },
                        new
                        {
                            Id = new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95b"),
                            Answers = "World Wide Web",
                            Category = 6,
                            Difficulty = 0,
                            Questions = "In a website browser address bar, what does “www” stand for?"
                        },
                        new
                        {
                            Id = new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95c"),
                            Answers = "1987",
                            Category = 2,
                            Difficulty = 1,
                            Questions = "In what year were the first Air Jordan sneakers released?"
                        },
                        new
                        {
                            Id = new Guid("3222152b-c0f9-472d-be10-e8aff0f4b95d"),
                            Answers = "21",
                            Category = 2,
                            Difficulty = 1,
                            Questions = " In a game of bingo, which number is represented by the phrase “two little ducks”?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}