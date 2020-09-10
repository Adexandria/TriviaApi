using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaApi.Entities;
using TriviaApi.Model;

namespace TriviaApi.Profiles
{
    public class TriviaProfile :Profile
    {
        
        public TriviaProfile()
        {
            CreateMap<Trivia, QuestionsDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(opt => opt.Id))
            .ForMember(dest => dest.Question, opt => opt.MapFrom(opt => opt.Questions))
            .ForMember(dest => dest.Category, opt => opt.MapFrom(opt => opt.Category.ToString()));

            CreateMap<Trivia, QuestionDto>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(opt => opt.Id))
           .ForMember(dest => dest.Question, opt => opt.MapFrom(opt => opt.Questions))
            .ForMember(dest => dest.Answer, opt => opt.MapFrom(opt => opt.Answers))
           .ForMember(dest => dest.Category, opt => opt.MapFrom(opt => opt.Category.ToString()))
            .ForMember(dest => dest.Difficulty, opt => opt.MapFrom(opt => opt.Difficulty.ToString()));
           
        }
    }
}
