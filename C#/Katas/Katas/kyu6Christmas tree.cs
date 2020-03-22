using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6Christmas_tree
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ChristmasTree(0));
            Console.WriteLine(" --- ");
            Console.WriteLine(ChristmasTree(1));
            Console.WriteLine(" --- ");
            Console.WriteLine(ChristmasTree(2));
            Console.WriteLine(" --- ");
            Console.WriteLine(ChristmasTree(3));
            Console.WriteLine(" --- ");
        }

        public static string ChristmasTree(int height)
        {
            if(height == 0) return "";
            if(height == 1) return "*";
            if(height == 2) return " * \n***";
            var listRows = new LinkedList<string>();
            var first = new string('*' , (height * 2) - 1);
            listRows.AddFirst(first);
            first = " " + first.Substring(1, first.Length - 2) + " ";
            listRows.AddFirst(first);
            while (first.Count(c => c.Equals('*')) > 1)
            {
                first = first.Replace(" *", "  ");
                first = first.Replace("* ", "  ");
                listRows.AddFirst(first);
            }
            return string.Join("\n", listRows.ToList());
        }
    }
}