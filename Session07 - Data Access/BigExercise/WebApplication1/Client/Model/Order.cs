using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Client.Model
{
    public class Order
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        
        [JsonPropertyName("orderDate")]
        public DateTime orderDate { get; set; }
        
        [JsonPropertyName("orderNumber")]
        public string orderNumber { get; set; }
        
        [JsonPropertyName("cats")]
        public ICollection<Cat> Cats { get; set; }
    }
}