using System.Collections.Generic;

namespace Katas
{
    public class SortBinaryTreeByLevels
    {
        public static List<int> TreeByLevels(Node node)
        {
            if(node == null) return new List<int>();
            List<int> answer = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                Node actualNode = queue.Dequeue();
                answer.Add(actualNode.Value);
                if (actualNode.Left != null) queue.Enqueue(actualNode.Left);
                if (actualNode.Right != null) queue.Enqueue(actualNode.Right);
            }
            return answer;
        }
    }

    public partial class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(Node l, Node r, int v)
        {
            Left = l;
            Right = r;
            Value = v;
        }
    }
}