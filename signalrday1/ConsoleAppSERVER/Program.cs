using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSERVER
{
    class Program
    {
            static void Main(string[] args)
            {
                //Host URl Hubs Startup
                using (WebApp.Start<Startup1>(new StartOptions("http://localhost:9999/")))
                {

                    Console.WriteLine("Connected Success");
                    Console.WriteLine("Press any Key To Stop Server");
                    Console.ReadLine();
                }


            }
        }
    }
