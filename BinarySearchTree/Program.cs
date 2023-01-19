﻿namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Binary Search Tree Program");
            BinarySearch<int> binarySearch = new BinarySearch<int>(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.Display();
        }
    }
}