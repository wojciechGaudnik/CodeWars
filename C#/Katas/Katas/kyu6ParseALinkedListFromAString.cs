using System;
using System.Collections.Generic;

namespace KatasNew
{
    public class kyu6ParseALinkedListFromAString
    {
        public static Node Parse(string nodes)
        {
            var split = nodes.Split(" -> ");
            if (!int.TryParse(split[0], out var data)) return null;
            var newNodes = new string[split.Length - 1];
            Array.Copy(split, 1, newNodes, 0, split.Length - 1);
            return new Node(data, Parse(string.Join(" -> ", newNodes)));
        }
    }




    public class Node : Object
    {
        public int Data;
        public Node Next;

        public Node(int data, Node next = null)
        {
            this.Data = data;
            this.Next = next;
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType()) { return false; }

            return this.ToString() == obj.ToString();
        }

        public override string ToString()
        {
            List<int> result = new List<int>();
            Node curr = this;

            while (curr != null)
            {
                result.Add(curr.Data);
                curr = curr.Next;
            }

            return String.Join(" -> ", result) + " -> null";
        }
    }

}