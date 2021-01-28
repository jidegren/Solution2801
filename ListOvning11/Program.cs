using System;
using System.Collections.Generic;

namespace ListOvning11
{
    class Program
    {
        static List<string> names = new List<string> { "Robin", "Eva" };
        static void Main(string[] args)
        {

            Console.WriteLine($"Here is your list!");
            Console.WriteLine();
            names.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Enter a new name");
            string input = Console.ReadLine();
            AddName(input);

            Console.Clear();
            Console.WriteLine("Here is you new List");
            names.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Enter a name you want to remove");
            string removeName = Console.ReadLine();
            RemoveName(removeName);
            Console.Clear();
            names.ForEach(Console.WriteLine);
            Console.Clear();
            SortNames();
            Console.WriteLine("Here is your list sorted by the first Character");
            names.ForEach(Console.WriteLine);

            //Add
            //Remove
            //RemoveAt
            //Contains
            //IndexOf
            //Count (property)
            //Insert
            //LastIndexOf
            //Reverse
            //Sort
        }

        private static void SortNames()
        {
            names.Sort();
        }

        private static void RemoveName(string removeName)
        {
            names.Remove(removeName);
        }

        private static void AddName(string name)
        {
            names.Add(name);
        }
    }
}
