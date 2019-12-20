using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class UniqueInOrderK
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T previous = default (T);
            Console.WriteLine(previous.ToString());
            if (iterable.Count() == 0) return iterable;
            IList<T> answer = new List<T>();
            IEnumerator<T> temp = iterable.GetEnumerator();
            temp.MoveNext();
            var last = temp.Current;
            answer.Add(last);
            while (temp.MoveNext())
            {
                if (!last.Equals(temp.Current))
                {
                    answer.Add(temp.Current);
                    last = temp.Current;
                }
            }
            return answer;
        }
    }
}