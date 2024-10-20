using PiecesOfArt_Application.Business_Layer.BLL.Models;

namespace PiecesOfArt_Application.Interface_Layer.PRL.Dto_model
{
    public class LoyaltyCardDTO
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

    
        public virtual List<User>? Users { get; set; }
    }
}
