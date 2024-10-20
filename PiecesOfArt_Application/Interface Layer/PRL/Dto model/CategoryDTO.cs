using PiecesOfArt_Application.Business_Layer.BLL.Models;
using System.Text.Json.Serialization;

namespace PiecesOfArt_Application.Interface_Layer.PRL.Dto_model
{
    public class CategoryDTO
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual List<PieceOfArt>? ArtPieces { get; set; }
    }
}
