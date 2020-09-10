using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TriviaApi.Entities;
using TriviaApi.Helpers;
using TriviaApi.Model;
using TriviaApi.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TriviaApi.Controllers
{
    [ApiController]
    [Route("api/question")]
    public class Questions : ControllerBase
    {
        private readonly IData data;
        private readonly IMapper mapper;
        public Questions(IData data, IMapper mapper)
        {
            this.data = data ?? throw new NullReferenceException(nameof(data));
            this.mapper = mapper ?? throw new NullReferenceException(nameof(mapper));
        }
        [HttpGet(Name = "Questions")]
        [HttpHead]
        public IActionResult GetQuestions(Paging sizes)
        {
            var questions = data.GetTrivia(sizes);
            if (questions == null)
            {
                return NotFound();
            }
            var pagingMeta = new
            {
                pageSize = questions.PageSize,
                count = questions.TotalCount,
                totalPage = questions.TotalPage,
                current = questions.CurrentPage
            };
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagingMeta));
            var link = CreateQuestionsLink(sizes, questions.HasNext, questions.Hasprevious);
            var addedlink = mapper.Map<IEnumerable<QuestionsDto>>(questions);
            var question = addedlink.Select(a =>
            {
                var questionsdictionary = a.ShapeData(sizes.Fields) as IDictionary<string, object>;
                var newlink = CreateQuestionLink((Guid)questionsdictionary["Id"], null);
                questionsdictionary.Add("links", newlink);
                return questionsdictionary;
            });
            var linkCollection = new
            {
                value = question,
                link
            };
            return Ok(linkCollection);
        }
        [HttpGet("{id}",Name ="Question")]
        public async Task<ActionResult<QuestionDto>> GetQuestionById(Guid id)
        {
            var question = await data.GetById(id);
            if(id == null)
            {
                return NotFound();
            }
            var questionDto = mapper.Map<QuestionDto>(question);
            return Ok(questionDto);
        }
        [HttpPost("{id}",Name ="PostQuestion")]
        public async Task<ActionResult<QuestionDto>> PostAnswer(Guid id,AnswerDto answer)
        {
            var question = await data.GetById(id);
            if (id == null)
            {
                return NotFound();
            }

            if (question.Answers.ToLower().Contains(answer.Answer.ToLower()))
            {
                return this.StatusCode(StatusCodes.Status202Accepted,"Answer is corrrect!!!!!!");
            }
            else
            {
              
              return this.StatusCode(StatusCodes.Status406NotAcceptable, "Answer is wrong!!!pls try again");
            }
           
        }
        private string CreateQuestionUrl(Paging sizes, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("Questions", new
                    {
                        fields = sizes.Fields,
                        pageNumber = sizes.PageNumber - 1,
                        pageSize = sizes.PageSize
                    });
                case ResourceUriType.Nextpage:
                    return Url.Link("Questions", new
                    {
                        fields = sizes.Fields,
                        pageNumber = sizes.PageNumber + 1,
                        pageSize = sizes.PageSize
                    });
                case ResourceUriType.Current:
                default:
                    return Url.Link("Questions", new
                    {
                        fields = sizes.Fields,
                        pageNumber = sizes.PageNumber,
                        pageSize = sizes.PageSize
                    });


            }

        }
       
        private IEnumerable<LinkDto> CreateQuestionLink(Guid id, string field)
        {
            var link = new List<LinkDto>();
            if (string.IsNullOrWhiteSpace(field))
            {
                link.Add(new LinkDto(Url.Link("Question", new { id }), "self", "GET"));
            }
            else
            {
                link.Add(new LinkDto(Url.Link("Question", new { id, field }), "self", "GET"));
            }
            link.Add(new LinkDto(Url.Link("PostQuestion", new { id }), "PostAnswer", "Post"));
            return link;
        }

        private IEnumerable<LinkDto> CreateQuestionsLink(Paging sizes, bool hasNext, bool hasPrevious)
        {
            var links = new List<LinkDto>();
            links.Add(new LinkDto(CreateQuestionUrl(sizes, ResourceUriType.Current), "self", "GET"));

            if (hasNext)
            {
                links.Add(new LinkDto(CreateQuestionUrl(sizes, ResourceUriType.Nextpage), "Nextpage", "GET"));
            }
            if (hasPrevious)
            {
                links.Add(new LinkDto(CreateQuestionUrl(sizes, ResourceUriType.PreviousPage), "Previouspage", "GET"));
            }
            return links;
        }
    }
}
   


