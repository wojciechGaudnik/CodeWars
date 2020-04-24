using System;
using System.Collections;

namespace Katas
{
    public partial class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static void Main(string[] args)
        {
            var test = BuildOneTwoThree();
            test = InsertNth(test, 1, 23);

            Console.WriteLine(test.Data);
            Console.WriteLine(test.Next.Data);
            Console.WriteLine(test.Next.Next.Data);
            // Console.WriteLine(test.Next.Next.Next.Data);
            // Console.WriteLine(test.Next.Next.Next.Next.Data);
        }

        public static Node InsertNth(Node head, int index, int data)
        {
            var dataList = new ArrayList();
            while (head != null)
            {
                dataList.Add(head.Data);
                head = head.Next;
            }
            if(index > dataList.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            dataList.Insert(index, data);
            Node nodeAnswer = new Node((int) dataList[0]);
            dataList.RemoveAt(0);
            Node actual = nodeAnswer;
            foreach (var one in dataList)
            {
                actual.Next = new Node((int)one);
                actual = actual.Next;
            }
            return nodeAnswer;
        }

        private static Node BuildNode(Node head, ArrayList arrayList)
        {
            if (true)
            {

            }

            return null;
        }

        // public static void PrintNode(Node node)
        // {
        //     var toPrint = node;
        //     while (toPrint.)
        //     {
        //
        //     }
        // }

        public static Node BuildNew(int n)
        {
            Node answer = new Node(0);
            var data = 1;
            while (n-- > 0)
            {
                answer.Data = data ++;
                answer.Next = null;
            }
            return null;
        }

        // public static Node InsertNth(Node head, int index, int data)
        // {
        //     if (index == 0)
        //     {
        //         var nodeBuff = head;
        //         head.Next = new Node(data);
        //         head.Next.Next = nodeBuff;
        //         return head;
        //     }
        //     return InsertNth(head.Next, --index, data);
        // }

        public static Node BuildOneTwoThree()
        {
            var answer = new Node(1);
            answer.Next = new Node(2);
            answer.Next.Next = new Node(3);
            return answer;
        }
    }
}