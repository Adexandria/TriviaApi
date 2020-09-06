using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaApi.Entities;
using TriviaApi.Helpers;
using TriviaApi.Model;

namespace TriviaApi.Service
{
    public class DataRepos : IData
    {
        private readonly Dbcontext db;
        private readonly IPropertyMappingService propertyMapping;
        public DataRepos(Dbcontext db,IPropertyMappingService propertyMapping)
        {
           this.db = db?? throw new NullReferenceException(nameof(db));
            this.propertyMapping = propertyMapping ?? throw new NullReferenceException(nameof(propertyMapping));
        }

        public async Task<Trivia> GetById(Guid id)
        {
            if(id== null)
            {
                throw new NullReferenceException(nameof(id));
            }
            return await db.Trivias.Where(r => r.Id == id).FirstOrDefaultAsync();
        }

        public PageList<Trivia> GetTrivia(Paging paging)
        {
            var questions = db.Trivias.OrderBy(r => r.Id);
          
            if (!string.IsNullOrWhiteSpace(paging.Orderby))
            {
                var question = propertyMapping.GetPropertyMapping<QuestionsDto,Trivia>();
                questions = questions.ApplySort(paging.Orderby, question);
            }
            return PageList<Trivia>.Create(questions, paging.PageNumber, paging.PageSize);
        }

    }
}
