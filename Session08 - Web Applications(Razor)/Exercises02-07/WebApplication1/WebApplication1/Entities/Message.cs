namespace WebApplication1.Entities
{
    public class MessageFromModel
    {
        public string message { get; set; }

        public void sayHi(string text)
        {
            message = text; 
        }
    }
}