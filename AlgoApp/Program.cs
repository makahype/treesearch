using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TreeBased v1.0 - beta");
            Console.WriteLine("input a command: create, add, print, end");

            string input = Console.ReadLine();
            CLI inter_handler = new CLI();
            Node curr = null;

            while (input != "end") {

                curr = inter_handler.RouteCommand(input, curr);                
                input = Console.ReadLine();
                

            }

        }
    }
}
