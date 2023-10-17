using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();
        
            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser,AppUserRegisterDTOs>();

            CreateMap<AppUserSignInDTOs, AppUser>();
            CreateMap<AppUser, AppUserSignInDTOs>();

            CreateMap<AnnouncementListDTO,Announcement>().ReverseMap();   

            CreateMap<AnnouncementUpdateDto,Announcement>().ReverseMap();

			CreateMap<SendMessageDto, ContactUs>().ReverseMap();


		}
	}
}
