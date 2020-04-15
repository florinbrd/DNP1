using System; // indexers
using System.Collections;

namespace ConsoleApp2
{
    public class Schedule
    {
        Hashtable dates = new Hashtable();

        public string this[DateTime d]
        {
            get { return (string) dates[d]; }

            set { dates[d] = value; }
        }

        public string this[string d]
        {
            get { return (string) dates[DateTime.Parse(d)]; }
            set { dates[DateTime.Parse(d)] = value; }
        }
    }
}