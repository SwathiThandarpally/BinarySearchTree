namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Binary Search Tree Program");
            //UC_1
            BinarySearch<int> binarySearch = new BinarySearch<int>(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.Display();
            Console.WriteLine("----------------------------------------");
            //UC_2
            BinarySearch<int> binarySearch1 = new BinarySearch<int>(56);
            binarySearch1.AddNode(30);
            binarySearch1.AddNode(70);
            binarySearch1.AddNode(22);
            binarySearch1.AddNode(40);
            binarySearch1.AddNode(11);
            binarySearch1.AddNode(63);
            binarySearch1.AddNode(67);
            binarySearch1.AddNode(16);
            binarySearch1.AddNode(60);
            binarySearch1.AddNode(95);
            binarySearch1.AddNode(65);
            binarySearch1.AddNode(3);
            binarySearch1.Display();
            Console.WriteLine("----------------------------------------");
            //UC_3
            SearchBinary<int> search = new SearchBinary<int>(56);
            search.AddNode(30);
            search.AddNode(70);
            search.AddNode(22);
            search.AddNode(40);
            search.AddNode(11);
            search.AddNode(63);
            search.AddNode(67);
            search.AddNode(16);
            search.AddNode(60);
            search.AddNode(95);
            search.AddNode(65);
            search.AddNode(3);
            search.Display();
            search.Size();
            bool result = search.Equals(67);
            Console.WriteLine(result);


        }
    }
}