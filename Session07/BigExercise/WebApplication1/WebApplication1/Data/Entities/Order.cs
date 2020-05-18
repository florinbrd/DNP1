using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Entities
{
    public class Order
    {
        [Key] public int id { get; set; }
        
        public DateTime orderDate { get; set; }
        
        public string orderNumber { get; set; }
        
        public ICollection<Cat> Cats { get; set; }
    }
}