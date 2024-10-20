using AutoMapper;
using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;

namespace PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<LoyaltyCard, LoyaltyCardDTO>();
            CreateMap<PieceOfArt, PieceOfArtDTO>();
            CreateMap<User, UserDTO>();
        }
    }
}
