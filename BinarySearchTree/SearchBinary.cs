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
        public SearchBinary<T> left;
        public SearchBinary<T> right;
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
                if (this.left == null) this.left = new SearchBinary<T>(value);
                else
                    this.left.AddNode(value);

            }
            else
            {
                if (this.right == null) this.right = new SearchBinary<T>(value);
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
        public SearchBinary<T> FindElement(T element, SearchBinary<T> node)
        {
            if (node != null)
            {
                if (element.Equals(node.Data))
                {
                    return node;
                }
                if (element.CompareTo(node.Data) < 0)
                {
                    return FindElement(element, node.left);
                }
                else
                {
                    return FindElement(element, node.right);
                }
            }
            return null;
        }
    }
}
