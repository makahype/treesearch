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
            Console.WriteLine("input a command:");
            Console.WriteLine("create: start a key value pair tree");
            Console.WriteLine("add: add a key value pair to an existing tree");
            Console.WriteLine("print: display tree structure (only keys are displayed)");
            Console.WriteLine("use: designate a namespace to store and load data from");
            Console.WriteLine("load: build tree from data saved under current namespace");
            Console.WriteLine("save: write current tree disk under current namespace");
            Console.WriteLine("end: close the application");

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
