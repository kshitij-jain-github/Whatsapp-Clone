using AutoMapper;
using Whatsapp.Clone.Models;
using Whatsapp.Clone.ViewModels;

namespace Whatsapp.Clone.Mappings
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomViewModel>()
                .ForMember(dst => dst.Admin, opt => opt.MapFrom(x => x.Admin.UserName));

            CreateMap<RoomViewModel, Room>();
        }
    }
}
