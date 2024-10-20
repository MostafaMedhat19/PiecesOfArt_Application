using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PiecesOfArt_Application.Business_Layer.BLL.Models;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Data;
using PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Interface;
using PiecesOfArt_Application.Interface_Layer.PRL.Dto_model;

namespace PiecesOfArt_Application.Infrastructures_Layer.DAL.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
    
        public UserRepository (AppDbContext context)
        {
            _context = context;
           
        }
        public void Delete(int id)
        {
            var user = _context.users.Find(id);
            if (user != null)
            {
                _context.users.Remove(user);
                _context.SaveChanges();
            }

            var art = _context.pieceOfArts.Find(id);
            if (art != null)
            {
                _context.pieceOfArts.Remove(art);
                _context.SaveChanges();
            }

            var category = _context.categories.Find(id);
            if (category != null)
            {
                _context.categories.Remove(category);
                _context.SaveChanges();
            }

            var loyaltyCard = _context.loyaltyCards.Find(id);
            if (loyaltyCard != null)
            {
                _context.loyaltyCards.Remove(loyaltyCard);
                _context.SaveChanges();
            }
        }

        public List<User> Display()
        {
             return _context.users
          .Include(u => u.PurchasedArtPieces)
          .ThenInclude(p => p.Category)
          .Include(u => u.LoyaltyCard)
          .ToList();
          
        }

        public void Update( User user)
        {
            var users = _context.users.Find(user.Id);
            if (user != null)
            {
                users.Name = user.Name;
                users.Age = user.Age;
                users.PurchasedArtPieces.FirstOrDefault().Title =user.PurchasedArtPieces.FirstOrDefault().Title;
                users.PurchasedArtPieces.FirstOrDefault().Category.Name = user.PurchasedArtPieces.FirstOrDefault().Category.Name;
                users.LoyaltyCard.Name = user.LoyaltyCard.Name;
                _context.SaveChanges();
            }
        }

        public User FindById(int id)
        {
            return _context.users.Find(id);
        }

    }
}
