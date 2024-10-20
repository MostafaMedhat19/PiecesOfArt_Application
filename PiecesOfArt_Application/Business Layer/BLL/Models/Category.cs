using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PiecesOfArt_Application.Business_Layer.BLL.Models
{
    public class Category
    {
        public int Id { get; set; }

    
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [JsonIgnore]
        //[IgnoreDataMember]
        public virtual List<PieceOfArt>? ArtPieces { get; set; }
    }
}
