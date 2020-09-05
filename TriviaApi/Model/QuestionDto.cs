using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TriviaApi.Entities;

namespace TriviaApi.Model
{
    public class QuestionDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Question { get; set; }
        public string Answers { get; set; }
        public Category Category { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
