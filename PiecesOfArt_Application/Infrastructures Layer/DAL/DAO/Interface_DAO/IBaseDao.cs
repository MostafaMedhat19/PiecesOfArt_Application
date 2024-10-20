using System.Collections.Generic;

namespace PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Interface_DAO
{
    public interface IBaseDao<T> where T : class
    {
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
