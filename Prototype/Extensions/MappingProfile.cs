using AutoMapper;
using Prototype.Bll.Models;
using Prototype.Data.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Hremployee, HrEmployeeViewModel>();
            CreateMap<HrEmployeeViewModel, Hremployee>();
        }
    }
}
