using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu5CanYouGetTheLoop
    {
        public static int getLoopSize(Node startNode){
            var list = new List<Node>();
            var set = new HashSet<Node>();
            var setLastSize = -1;
            while (setLastSize != set.Count)
            {
                setLastSize = set.Count();
                set.Add(startNode);
                list.Add(startNode);
                startNode = startNode.Next;
            }

            var count = 0;
            var lastNode = list.Last();

            foreach (var node in list)
            {
                count++;
                if (node.Equals(lastNode))
                {
                    return list.Count - count;
                }
            }
            return 0;
        }
    }
}