using System;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Message : PageModel
    {
        public string message { get; set; } = "Hello there. How are you?  "; 
        public void OnGet()
        {
            message += $"Server time is {DateTime.Now}";
        }

        public void sayHello(string text)
        {
            message = text; 
        }
    }
}