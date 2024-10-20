using Microsoft.EntityFrameworkCore;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Interface_DAO;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Data;
using System.Collections.Generic;
using System.Linq;

namespace PiecesOfArt_Application.Infrastructures_Layer.DAL.DAO.Implementation_DAO
{
    public class BaseDao<T> : IBaseDao<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseDao(AppDbContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
