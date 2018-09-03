using AutoMapper;
using Prototype.Bll.Models;
using Prototype.Data.Pocos;

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
