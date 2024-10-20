using AutoMapper;
using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Interface;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Interface_DAO;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Interface;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;
using System.Collections.Generic;
using System.Linq;

namespace PiecesOfArt_Application.Business_Layer.BLL.Service_Controller.Vaildation_Data.Implementation
{
    public class UserService<T> : IUserService<T> where T : class
    {
        private readonly IBaseDao<T> _baseDao;
     
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper, IBaseDao<T> baseDao)
        {
            _baseDao = baseDao;
           
            _mapper = mapper;
        }

       

     
        public bool AddEntity(T entity)
        {
            if (entity != null)
            {
                _baseDao.Add(entity);
                return true;
            }
            return false;
        }
        public bool DeleteEntity(int id)
        {
            var entity = _baseDao.GetById(id);
            if (entity != null)
            {
                _baseDao.Delete(id);
                return true;
            }
            return false;
        }
        public IEnumerable<T> GetAllEntities()
        {
            return _baseDao.GetAll() ?? Enumerable.Empty<T>();
        }

        public T GetEntityById(int id)
        {
            return _baseDao.GetById(id);
        }

        public bool UpdateEntity(int id, T entity)
        {
            var existingEntity = _baseDao.GetById(id);
            if (existingEntity != null)
            {
                _baseDao.Update(entity);
                return true;
            }
            return false;
        }
    }
}
