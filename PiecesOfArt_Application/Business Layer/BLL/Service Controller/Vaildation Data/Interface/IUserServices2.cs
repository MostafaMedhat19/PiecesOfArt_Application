using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;

namespace PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Interface
{
    public interface IUserServices2
    {
        public List<UserDTO> DisplayInfo();
        public bool DeleteData(int id);

        public bool UpdateData(User user);
    }
}
