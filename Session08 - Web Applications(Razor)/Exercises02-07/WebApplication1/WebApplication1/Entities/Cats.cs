using System;
using System.Text.Json.Serialization;

namespace WebApplication1.Entities
{
    public class Cats
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
      
        [JsonPropertyName("name")]
        public string Name { get; set;  }
        
        [JsonPropertyName("color")]
        public string color { get; set; }
        
        [JsonPropertyName("ordernumber")]
        public decimal orderNumber { get; set; }
        
        [JsonPropertyName("date")]
        public DateTime Birthdate { get; set; }
        
        [JsonPropertyName("favdish")]
        public string favoriteDish { get; set; }
    }
}