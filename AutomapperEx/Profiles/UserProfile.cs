using AutoMapper;
using AutomapperEx.Models;
using AutomapperEx.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperEx.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(destination => destination.FirstName, operation => operation.MapFrom(source => source.FirstName + " ( mapped ) "))
                .ForMember(destination => destination.JobExpression, operation => operation.MapFrom(source => source.JobExpression + " ( mapped ) "))
                .ForMember(destination => destination.WorkedFirms, operation => operation.MapFrom(source => source.WorkedFirms + " ( mapped ) "))
                .ForMember(destination => destination.LastName, operation => operation.MapFrom(source => source.LastName + " ( mapped ) "));
        }
    }
}
