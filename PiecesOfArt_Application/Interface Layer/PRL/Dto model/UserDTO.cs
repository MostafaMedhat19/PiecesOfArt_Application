using PiecesOfArt_Application.Business_Layer.BLL.Models;

namespace PiecesOfArt_Application.Interface_Layer.PRL.Dto_model
{
    public class UserDTO
    {
        public string Name { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;

        public int Age { get; set; }

        public List<PieceOfArt>? PurchasedArtPieces { get; set; }
        public LoyaltyCard? LoyaltyCard { get; set; }
    }
}
