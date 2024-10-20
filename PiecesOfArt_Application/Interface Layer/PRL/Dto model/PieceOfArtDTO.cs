using PiecesOfArt_Application.Business_Layer.BLL.Models;

namespace PiecesOfArt_Application.Interface_Layer.PRL.Dto_model
{
    public class PieceOfArtDTO
    {
        public string Title { get; set; } = string.Empty;

        public double Price { get; set; }

        public DateTime PublicationDate { get; set; }
        public Category? Category { get; set; }
        public User? User { get; set; }
    }
}
