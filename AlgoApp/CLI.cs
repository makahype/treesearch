using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoApp
{
    class CLI
    {

        string appId;
        string node_delim = "btnd::";
        string data_itm_delim = "btitm::";

        public CLI() { }

        public Node RouteCommand(string cmd, Node node) {

            switch (cmd) {
                case "create":
                    node = this.Create();
                    break;
                case "add":
                    node = this.Add(node);
                    break;
                case "print":
                    Console.WriteLine(node.Print());
                    break;
                case "save":
                    this.Save(node);
                    break;
                case "use":
                    this.Use();
                    break;
                case "load":
                    node = this.Load();
                    break;
                default:
                    Console.WriteLine("invalid command");
                    break;
            }

            return node;
        }


        public string Use() {

            Console.WriteLine("Provide an app ID");
            string val = Console.ReadLine();
            this.appId = val;

            return val;
        }



        public Node Create() {

            Console.WriteLine("Input a key");
            string key = Console.ReadLine();

            int x = 0;
            Boolean inttest = Int32.TryParse(key, out x);

            while (!inttest) {
                Console.WriteLine("Not a valid integer, try again");

                key = Console.ReadLine();
                inttest = Int32.TryParse(key, out x);

            }

            Console.WriteLine("Provide a value to store under the key");
            string val = Console.ReadLine();

            //create node from data
            List<string> l1 = new List<string>();
            l1.Add(val);
            Node res = new Node(x, l1);

            return res;

        }

        public Node Add(Node node) {

            Console.WriteLine("Input a key");
            string key = Console.ReadLine();

            int x = 0;
            Boolean inttest = Int32.TryParse(key, out x);

            while (!inttest)
            {
                Console.WriteLine("Not a valid integer, try again");

                key = Console.ReadLine();
                inttest = Int32.TryParse(key, out x);

            }

            Console.WriteLine("Provide a value to store under the key");
            string val = Console.ReadLine();

            node.Add(x, val);
            return node;
        }

        public void Save(Node node) {
            string res = node.PrintFull();

            //make sure directory exists
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\TreeSearch");


            //clear file
            System.IO.File.Delete(@"C:\Users\Public\TreeSearch\" + this.appId + ".txt");

            //create file
            System.IO.File.WriteAllText(@"C:\Users\Public\TreeSearch\"+this.appId + ".txt", res);


        }

        public Node Load() {

            string line;
            Node node = null;
            int delim_pos;
            int key = 0;
            List<string> datalist;
            Boolean parsetest = false;

            //get stored data from file
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Public\TreeSearch\" + this.appId + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                //grab node key
                delim_pos = line.IndexOf(this.node_delim);
                if (delim_pos == 0) {
                    parsetest = Int32.TryParse(line.Replace(this.node_delim, "").Replace(Environment.NewLine,""), out key);
                }


                //or this is a data line, create the node or add a new one
                delim_pos = line.IndexOf(this.data_itm_delim);
                if (delim_pos == 0 && parsetest)
                {
                    if (node == null) {
                        //create node from data
                        datalist = new List<string>();
                        datalist.Add(line.Replace(this.data_itm_delim, "").Replace(Environment.NewLine, ""));
                        node = new Node(key, datalist);

                    } else {
                        //add to node tree already started
                        node.Add(key, line.Replace(this.data_itm_delim, "").Replace(Environment.NewLine, ""));
                    }                    
                }

            }


            file.Close();

            return node;
        }


    }
}
