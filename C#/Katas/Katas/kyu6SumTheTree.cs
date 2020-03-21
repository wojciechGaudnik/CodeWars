
namespace Katas
{
    public class kyu6SumTheTree
    {
        public static int SumTree(Node1 root)
        {
            return SumNode(root);
        }

        private static int SumNode(Node1 one)
        {
            var sum = 0;
            if (one.Left != null) sum += SumNode(one.Left);
            if (one.Right != null) sum += SumNode(one.Right);
            return one.Value + sum;
        }

    }

    public class Node1
    {
        public int Value;
        public Node1 Left;
        public Node1 Right;

        public Node1(int value, Node1 left = null, Node1 right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}