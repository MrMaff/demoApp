using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch
{
    class TreeNode
    {
        public int Number { get; }
        public TreeNode left = null;
        public TreeNode right = null;

        public TreeNode(int number)
        {
            this.Number = number;
        }

    }

    class BinaryTree
    {
        private TreeNode rootNode = null;

        public BinaryTree()
        { }


        public BinaryTree(int[] numberData, bool sorted)
        {
            if (sorted == false)
            {
                Array.Sort(numberData);
            }
            //Set Root Node
            int mid = numberData.Length / 2;
            this.rootNode = new TreeNode(numberData[mid]);
            //Add to the right
            AddMid(numberData, mid + 1, numberData.Length-1);
            //Add to the Left
            AddMid(numberData, 0, mid - 1);
        }

        private void AddMid(int[] numberData, int lpointer, int rpointer)
        {
            int mid = (lpointer + rpointer) / 2;
            Add(this.rootNode, new TreeNode(numberData[mid]));
            if (lpointer < rpointer)
            {
                //Add to the right
                AddMid(numberData, mid + 1, rpointer);
                //Add to the Left
                AddMid(numberData, lpointer, mid - 1);
            }
        }

        public bool Add(TreeNode CurrentNode, TreeNode NewLeaf)
        {
            bool added;
            if (NewLeaf.Number < CurrentNode.Number)
            {
                if (CurrentNode.left == null)
                {
                    CurrentNode.left = NewLeaf;
                    added = true;
                }
                else
                {
                    added = Add(CurrentNode.left, NewLeaf);
                }
            }
            else if (NewLeaf.Number > CurrentNode.Number)
            {
                if (CurrentNode.right == null)
                {
                    CurrentNode.right = NewLeaf;
                    added = true;
                }
                else
                {
                    added = Add(CurrentNode.right, NewLeaf);
                }
            }
            else added = false;
            return added;
        }

       public bool Contains(int num)
        {
            return CheckContains(num, this.rootNode);
        }

        private bool CheckContains(int num, TreeNode CurrentNode)
        {
            bool present = true;
            if (CurrentNode.Number == num)
            {
                present = true;
            }
            else if ((CurrentNode.left == null || CheckContains(num, CurrentNode.left) == false) && (CurrentNode.right == null || CheckContains(num, CurrentNode.right) == false))
            {
                present = false;
            }

            return present;

        }
    }

    
}
