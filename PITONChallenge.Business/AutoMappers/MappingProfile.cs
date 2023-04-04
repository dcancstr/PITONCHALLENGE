using System;
using System.Runtime.Intrinsics.X86;
using AutoMapper;
using PITONChallenge.Business.ViewModels;
using PITONChallenge.Entity.Concrete;

namespace PITONChallenge.Business.AutoMappers
{
	public class MappingProfile :Profile
	{
        public MappingProfile()
        {
            CreateMap<User, UserVM>().ReverseMap();

            CreateMap<Mission, MissionVM>().ReverseMap();
            //CreateMap<MissionVM, Mission>().ForMember(f => f.MissionGoalTime, opt => opt.MapFrom(f => f.MissionGoalTime));

            CreateMap<MissionCategory, MissionCategoryVM>().ReverseMap();
            
        }
    }
}

