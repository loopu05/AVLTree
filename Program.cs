using System;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>();
            tree.Add(12);
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(3);
                        
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            tree.Remove(6);
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
