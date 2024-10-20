using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Interface_DAO;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;

namespace PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Interface
{
    public interface IUserService<T>
    {
      
        public T GetEntityById(int id);
        public bool AddEntity(T entity);
        public bool UpdateEntity(int id ,T entity);
        public bool DeleteEntity(int id);
        public IEnumerable<T> GetAllEntities();
    }
}
