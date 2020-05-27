using System;
using System.Text.Json.Serialization;

namespace Client.Model
{
    public class Cat
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