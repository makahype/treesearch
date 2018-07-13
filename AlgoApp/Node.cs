using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoApp
{
    class Node
    {

        private int key;
        private List<string> data;
        private Node left;
        private Node right;



        public Node(int key, List<string> items) {
            this.key = key;
            this.data = items;
            this.left = null;
            this.right = null;
        }

        public Node GetLeft() {
            return this.left;
        }

        public Node GetRight() {
            return this.right;
        }

        public int GetKey()
        {
            return this.key;
        }

        public void Add(int key, string item) {
            if (this.key == key) {
                this.data.Add(item);
            }
            else if (key < this.key)
            {
                this.AddLeft(key, item);
            }
            else {
                this.AddRight(key, item);
            }

        }

        public void AddLeft(int key, string item) {

            if (this.left == null)
            {
                List<string> new_list = new List<string>();
                new_list.Add(item);
                Node new_item = new Node(key, new_list);
                this.left = new_item;
            }
            else {
                this.left.Add(key, item);
            }

        }

        public void AddRight(int key, string item) {

            if (this.right == null)
            {
                List<string> new_list = new List<string>();
                new_list.Add(item);
                Node new_item = new Node(key, new_list);
                this.right = new_item;
            }
            else
            {
                this.right.Add( key, item);
            }

        }

        public Node Search(int key) {

            return null;
        }

        public string Print() {

            string res = "Node " + this.key;
            if (this.left != null)
            {
                res = res + " < (L) " + this.left.Print();
            }
            else {
                res = res + " < ";
            }

            if (this.right != null)
            {
                res = res + " (R) " + this.right.Print() + " >";
            }
            else {
                res = res + " > ";
            }

            return res;
        }

        public List<string> GetData() {
            return this.data;
        }

    }
}
