using System.IO;

namespace ConsoleApp1
{
    public class Reader
    {
         string filename; 
         public string Data { get; set; }

         public Reader(string fn)
         {
             filename = fn; 
         }

         public void Read()
         {
             FileStream s = new FileStream(filename, FileMode.Open);
             StreamReader r = new StreamReader(s);
             Data = r.ReadToEnd();
             s.Close();
         }
    }
}