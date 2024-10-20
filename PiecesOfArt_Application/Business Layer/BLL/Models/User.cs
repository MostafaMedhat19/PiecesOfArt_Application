using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PiecesOfArt_Application.Business_Layer.BLL.Models
{
    public class User
    {
        public int Id { get; set; }

       
        public string Name { get; set; } = string.Empty;

     
        public string Email { get; set; } = string.Empty;

        public int Age { get; set; }

        [JsonIgnore]
        //[IgnoreDataMember]
        public virtual List<PieceOfArt>? PurchasedArtPieces { get; set; }

    
        public int? LoyaltyCardId { get; set; }

      
        [ForeignKey("LoyaltyCardId")]
        public LoyaltyCard? LoyaltyCard { get; set; }
    }
}
