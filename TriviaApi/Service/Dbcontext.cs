using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TriviaApi.Entities;

namespace TriviaApi.Service
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
        {

        }
        public DbSet<Trivia> Trivias { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id =Guid.Parse ("3222152b-c0f9-472d-be10-e8aff0f4b95a"),
                Questions= "What is the rarest M&M color?",
                Answers="Brown",
                Category=Category.Random,
                Difficulty =Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b95b"),
                Questions = "In a website browser address bar, what does “www” stand for?",
                Answers = "World Wide Web",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b95c"),
                Questions = "In what year were the first Air Jordan sneakers released?",
                Answers = "1987",
                Category = Category.History,
                Difficulty = Difficulty.Medium

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b95d"),
                Questions = " In a game of bingo, which number is represented by the phrase “two little ducks”?",
                Answers = "21",
                Category = Category.History,
                Difficulty = Difficulty.Medium

            });

        }
    }
}
