using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Users
    {
        public List<results> results = new List<results>();
    }

    public class results
    {
        public string gender { get; set; }
        public name name { get; set; }
        public location location { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(name.title + " " + name.first + " "+name.last);
            Console.WriteLine("Адрес проживания:");
            Console.WriteLine("{0}, {1} ({2})", location.postcode, location.city, location.street);
        }

    }

    public class name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class location
    {
        public string street { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public coordinates coordinates { get; set; }
    }

    public class coordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
