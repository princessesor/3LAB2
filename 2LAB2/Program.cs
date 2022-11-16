using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace _2LAB2
{
    public class GFG
    {
        //class cont left right child & of current node and key val
        public class Node
        {
            public string key;
            public Node left, right;

            public Node (string item)
            {
                key = item;
                left = right = null;
            }
        }
        // root of tree
        Node root;
        // constructor
        GFG()
        {
            root = null;
        }
        // method to call insertrec()
        void insert (string key)
        {
            root = insertRec(root, key);
        }
        // recursive func to insert a new key
        Node insertRec(Node root, string key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key == root.key)
                root.left = insertRec(root.left, key);
            else if (key == root.key) 
                    root.right = insertRec(root.right, key);

            return root;
        }
        // func to traverse
        void preorderRec(Node root)
        {
            if (root != null)
            {
                Console.Write(root.key + " ");
                preorderRec(root.left);
                preorderRec(root.right);
            }
        }
       
    }
    public class goods : IComparable
    {
        public string Name;
        public string barcode ;
        public string mdate;
        string edate;
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code
            ArrayList alist = new ArrayList();

             Dictionary<string, string> goods = new Dictionary<string, string>();
            goods.Add("goodsname:", "Chocolate");
            goods.Add("barcode", "xXZ990");
            goods.Add("manufacture date:", "3/jul/20");
            goods.Add("expiration date:", "3/aug/22");

            alist.AddRange(new object[] { "Chocolate", "xXZ990", "3/jul/20", "3/aug/22" });
            alist.Insert(1, "biscuits");
            alist.RemoveAt(0);
            goods.TryGetValue("biscuits", out string test);
            alist.Sort();

            foreach(KeyValuePair<string, string> kvp in goods)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            foreach(object o in alist)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("biscuits: {0}", goods.ContainsKey("biscuit"));

            IEnumerator en = goods.GetEnumerator();
            while (en.MoveNext())
            {
                goods g = (goods)en.Current; 
                Console.WriteLine(g); 
            }

            #endregion  
            
        }
    }
}
