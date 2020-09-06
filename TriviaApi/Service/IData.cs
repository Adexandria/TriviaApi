using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaApi.Entities;
using TriviaApi.Helpers;

namespace TriviaApi.Service
{
   public interface IData
    {
        public PageList<Trivia> GetTrivia(Paging paging);
        public Task<Trivia> GetById(Guid id);
    }
}
