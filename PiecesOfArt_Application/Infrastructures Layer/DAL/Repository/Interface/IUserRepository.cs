using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;

namespace PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Interface
{
    public interface IUserRepository
    {
        public List<User> Display(); 
        public void Delete(int id);
        public void Update(User user);
        public User FindById(int id);

    }
}
