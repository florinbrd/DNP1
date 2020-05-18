using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.DataModel
{
    public class Movie
    {
        
        [Key]public int Id { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [DisplayName("Title of the movie")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Title { get; set; }
        
        [DataType(DataType.Date)] 
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30, MinimumLength = 2)]
        public string Genre { get; set; }
        
        [Required]
        [Range(0, 100)]
        public decimal Price { get; set; }
        
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Rating { get; set; }

    }
}