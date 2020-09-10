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
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b95d"),
                Questions = " In a game of bingo, which number is represented by the phrase \"two little duck\"?",
                Answers = "21",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b95e"),
                Questions = "According to Greek mythology who was the first woman on earth?",
                Answers = "Pandora",
                Category = Category.History,
                Difficulty = Difficulty.Medium

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b95f"),
                Questions = "Samuel Tilden, Grover Cleveland, Al Gore and Hillary Clinton share what distinction among U.S. presidential candidates?",
                Answers = "They won the popular vote, but lost the electoral-college vote",
                Category = Category.History,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b99c"),
                Questions = "Which African country was formerly known as Abyssinia?",
                Answers = "Ethopia",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b96a"),
                Questions = "Tennis star Serena Williams won which major tournament while pregnant with her first child?",
                Answers = "The Australian Open",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b96b"),
                Questions = "In which European city would you find Orly airport?",
                Answers = "Paris",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b96c"),
                Questions = "Which singer’s real name is Stefani Joanne Angelina Germanotta?",
                Answers = "Lady Gaga",
                Category = Category.Music,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b96d"),
                Questions = "The only known monotremes in the animal kingdom are the echidna and which other creature?",
                Answers = "The Platypus",
                Category = Category.Science,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b96e"),
                Questions = "Kingston, Zuma, and Apollo are the sons of which American female pop star ?",
                Answers = "Gwen Stafani",
                Category = Category.Music,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b96f"),
                Questions = "Outside which New York building was John Lennon killed?",
                Answers = "Dakota Building",
                Category = Category.History,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b99a"),
                Questions = "What is the tallest breed of dog in the world?",
                Answers = "Great Dane",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b97a"),
                Questions = "Which of Shakespeare’s plays is the longest?",
                Answers = "Hamlet",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b97b"),
                Questions = "In the United Kingdom, what is the day after Christmas known as?",
                Answers = "Boxing Day",
                Category = Category.Music,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b97c"),
                Questions = "What is the tiny piece at the end of a shoelace called?",
                Answers = "Aglet",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b97d"),
                Questions = "What was the first toy to be advertised on television?",
                Answers = "Mr.Potato Head",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b97e"),
                Questions = "What is the loudest animal on Earth?",
                Answers = "Sperm Whale",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b97f"),
                Questions = "Which two U.S. states don’t observe Daylight Saving Time?",
                Answers = "Arizona and Hawaii",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b99b"),
                Questions = "Which country consumes the most chocolate per capita?",
                Answers = "Switzerland",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b98a"),
                Questions = "Where were the Declaration of Independence, the Constitution, and the Bill of Rights stored during World War II?",
                Answers = "Forx Knox",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b98b"),
                Questions = "Which Dutch artist painted “Girl with a Pearl Earring”?",
                Answers = "Vermeer",
                Category = Category.Random,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b98c"),
                Questions = "Which author wrote the ‘Winnie-the-Pooh’ books?",
                Answers = "A.A.Milne",
                Category = Category.Kids,
                Difficulty = Difficulty.Easy

            });
            model.Entity<Trivia>().HasData(new Trivia
            {
                Id = Guid.Parse("3222152b-c0f9-472d-be10-e8aff0f4b98d"),
                Questions = "Fissures, vents and plugs are all associated with which geological feature?",
                Answers = "Volcanos",
                Category = Category.Science,
                Difficulty = Difficulty.Easy

            });

        }
    }
}
