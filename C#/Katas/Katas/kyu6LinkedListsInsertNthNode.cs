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

        public static Node InsertNth(Node head, int index, int data)
        {
            var dataList = new ArrayList();
            while (head != null)
            {
                dataList.Add(head.Data);
                head = head.Next;
            }

            if (index > dataList.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            dataList.Insert(index, data);
            Node nodeAnswer = new Node((int) dataList[0]);
            dataList.RemoveAt(0);
            Node actual = nodeAnswer;
            foreach (var one in dataList)
            {
                actual.Next = new Node((int) one);
                actual = actual.Next;
            }

            return nodeAnswer;
        }
    }
}