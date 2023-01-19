using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public  class SearchBinary<T> where T : IComparable <T>
    {
        public T Data;
        public BinarySearch<T> left;
        public BinarySearch<T> right;
        public SearchBinary(T data)
        {
            this.Data = data;
            this.left = null;
            this.right = null;
        }
        int leftIndex = 0, rightIndex = 0;
        public void AddNode(T value)
        {
            T Nodevalue = this.Data;
            if (Nodevalue.CompareTo(value) > 0)
            {
                if (this.left == null) this.left = new BinarySearch<T>(value);
                else
                    this.left.AddNode(value);

            }
            else
            {
                if (this.right == null) this.right = new BinarySearch<T>(value);
                else
                    this.right.AddNode(value);
            }

        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftIndex++;
                this.left.Display();
            }
            Console.WriteLine(this.Data);
            if (this.right != null)
            {
                this.rightIndex++;
                this.right.Display();

            }

        }
        public void Size()
        {
            Console.WriteLine("Size of Binary Serach Tree " + (1 + leftIndex + rightIndex));
        }
        public bool search(T element, SearchBinary<T> node)
        {
            if (node == null)
                return false;
            if (node.Data.Equals(element))
            {
                Console.WriteLine("Element in binary search tree " + node.Data);
                return true;
            }
            else
                Console.WriteLine("Current element is {0} in binary search tree ", node.Data);
            if (element.CompareTo(node.Data) < 0)
                search(element, node);
            // search(node.left.Data);
            if (element.CompareTo(node.Data) > 0)
                search(element,  node );
              //  search(node.right.Data);
            return true;
        }
    }
}
