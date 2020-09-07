using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TriviaApi.Entities;

namespace TriviaApi.Model
{
    public class QuestionsDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
    }
}
