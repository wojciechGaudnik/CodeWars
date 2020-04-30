using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu5FunWithTreesArrayToTree
    {
        public class TreeNode
        {

            public TreeNode left;
            public TreeNode right;
            public int value;

            public TreeNode(int value, TreeNode left, TreeNode right)
            {
                this.value = value;
                this.left = left;
                this.right = right;
            }

            public TreeNode(int value)
            {
                this.value = value;
            }
        }

        public static void Main(string[] args)
        {

            var test1 = new[] {1, 2};
            Console.WriteLine(test1.Skip(1).ToArray().Length > 0);
            Console.WriteLine(test1.Skip(1).Skip(1).Skip(1).ToArray().Length > 0);


            // var test = ArrayToTree(new[] {1, 2, 3, 4, 5});
            var test = ArrayToTree(new int[] {17, 0, -4, 3, 15});
            Console.WriteLine(test.value);
            Console.WriteLine(test.left.value);
            Console.WriteLine(test.right.value);
            Console.WriteLine(test.left.left.value);
            Console.WriteLine(test.right.value);
            var test = new TreeNode(1, null,null);

        }

        public static TreeNode ArrayToTree(int[] array)
        {
            if (array.Length == 0) return null;
            var nodeList = new List<TreeNode>();
            foreach (var one in array) nodeList.Add(new TreeNode(one));
            var answer = nodeList.First();
            var step = 1;
            while (nodeList.ToArray().Length > 0)
            {
                var firstsList = nodeList.Take(step);
                nodeList = nodeList.Skip(step).ToList();
                step *= 2;
                var i = 0;
                foreach (var one in firstsList)
                {
                    if (nodeList.Count <= i) return answer;
                    one.left = nodeList[i++];
                    if (nodeList.Count <= i) return answer;
                    one.right = nodeList[i++];
                }
            }
            return answer;
        }


        // public static TreeNode ArrayToTree(int[] array)
        // {
        //     if (array.Length == 1) return new TreeNode(array[0]);
        //     if (array.Length == 2) return new TreeNode(array[0]) {left = new TreeNode(array[1])};
        //     if (array.Length == 3) return new TreeNode(array[0]) {left = new TreeNode(array[1]), right = new TreeNode(array[2])};
        //     return ArrayToTree(array.Skip(1).ToArray());
        // }
    }
}

