using ConsoleApp3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string URL = "https://randomuser.me/api/?results=14";
            ServiceUser serviceUser = new ServiceUser(URL);
            Users users= serviceUser.GetUsers();
            for(int i=0; i<users.results.Count; i++)
            {
                //results user = users.results[i];
                users.results[i].PrintInfo();
                Console.WriteLine("---------------------------------");
            }
        } 


    }

    
}
