using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt_Application.Business_Layer.BLL.Models
{
    public class PieceOfArt
    {
        public int Id { get; set; }

       
        public string Title { get; set; } = string.Empty;

        public double Price { get; set; }

        public DateTime PublicationDate { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }

        public User? User { get; set; }
    }
}
