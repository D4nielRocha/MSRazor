using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMS.Models
{
    public class Movie
    {

        public int ID { get; set; }
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string? Title { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; } = string.Empty;

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName="decimal(18, 2)")]

        public decimal? Price{ get; set; }

        public int Rating{ get; set; }
        public string Review { get; set; } = string.Empty;

    }
}
