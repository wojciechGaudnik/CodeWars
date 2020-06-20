using System;
using System.Collections.Generic;
using System.Linq;

namespace KatasNewNode
{
    public class kyu6ReverseASinglyLinkedList
    {
        public static void Main(string[] args)
        {
            var test = new Node(new int[] {1, 2, 3});
            var reversed = ReverseList(test);


            Console.WriteLine(test);

        }
        public static Node ReverseList(Node node)
        {
            Console.WriteLine(node);
            if (node?.Next == null) return node;
            var list = new LinkedList<int>();
            var currentNode = node;
            while (currentNode != null)
            {
                list.AddFirst(currentNode.Value);
                currentNode = currentNode.Next;
            }
            return new Node(list.ToArray());
        }

    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }

        public Node(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentException();
            if (array.Length == 1)
            {
                Value = array[0];
                return;
            }
            Value = array[0];
            Next = new Node(array.Skip(1).ToArray());
        }
    }
}