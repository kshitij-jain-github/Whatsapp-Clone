using AutoMapper;
using Whatsapp.Clone.Models;
using Whatsapp.Clone.ViewModels;

namespace Whatsapp.Clone.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(dst => dst.UserName, opt => opt.MapFrom(x => x.UserName));

            CreateMap<UserViewModel, ApplicationUser>();
        }
    }
}
