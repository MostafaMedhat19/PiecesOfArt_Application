using AutoMapper;
using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Interface;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Interface;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;

namespace PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Implementation
{
    public class UserServices2 : IUserServices2
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;
        public UserServices2(IUserRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public bool DeleteData(int id)
        {
            var user = _repository.FindById(id);
            if (user != null)
            {
                _repository.Delete(id);
                return true;
            }
            return false;
        }

        public List<UserDTO> DisplayInfo()
        {
            var userInfo = _repository.Display();
            return userInfo != null ? _mapper.Map<List<UserDTO>>(userInfo) : new List<UserDTO>();
        }
        public bool UpdateData(User user)
        {
            var existingUser = _repository.FindById(user.Id);
            if (existingUser != null)
            {
                _repository.Update(user);
                return true;
            }
            return false;
        }
    }
}
