using System;

namespace Katas
{
    public class kyu6LinkedListsLength_Count
    {
        public int Data;
        public kyu6LinkedListsLength_Count Next;

        public kyu6LinkedListsLength_Count(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static int Length(kyu6LinkedListsLength_Count head)
        {
            if (head == null) return 0;
            else
            {
                return 1 + Length(head.Next);
            }
        }


        public static int Count(kyu6LinkedListsLength_Count head, Predicate<int> func)
        {
            if (head == null) return 0;
            var count = 0;
            while (head != null)
            {
                if (func(head.Data)) count++;
                head = head.Next;
            }
            return count;
        }


    }
}