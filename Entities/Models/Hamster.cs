using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Models
{
    public class Hamster
    {
        public int HamsterId { get; set; }
        [Required]
        public string HamsterName { get; set; }
        [Required]
        public int HamsterAge { get; set; }
        [Required]
        public string FavFood { get; set; }
        [Required]
        public string Loves { get; set; }
        [Required]
        public string ImgName { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Games { get; set; }

    }
}