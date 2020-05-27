using System.Text.Json.Serialization;

namespace ConsoleApp2
{
    public class User
    {
        
        [JsonPropertyName("id")]
        public int id { get; set; }
        
        [JsonPropertyName("name")]
        public string name { get; set; }
    }
}