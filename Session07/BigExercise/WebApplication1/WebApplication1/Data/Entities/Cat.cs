using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Entities
{
    public class Cat
    {
        [Key] public int id { get; set; }
        
        [MaxLength(20)]
        [MinLength(2)]
        [Required]
        public string Name { get; set;  }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string color { get; set; }
        
        [Range(0,100)]
        [Required]
        public decimal orderNumber { get; set; }
        
        public DateTime Birthdate { get; set; }
        
        public string favoriteDish { get; set; }
        
        
        
        
    }
}