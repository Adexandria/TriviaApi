using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TriviaApi.Entities
{
    public class Trivia
    {
        [Key]
        public Guid Id { get; set; }
        public string Questions { get; set; }
        public string Answers { get; set; }
        public Category Category { get; set; }
        public Difficulty Difficulty { get; set; }

    }
}
