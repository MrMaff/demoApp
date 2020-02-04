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

        public void Add(TreeNode NewLeaf)
        {
            if (NewLeaf.Number < this.Number)
            {
                if (this.left == null)
                {
                    this.left = NewLeaf;
                }
                else
                {
                    this.left.Add(NewLeaf);
                }
            }
            if (NewLeaf.Number > this.Number)
            {
                if (this.right == null)
                {
                    this.right = NewLeaf;
                }
                else
                {
                    this.right.Add(NewLeaf);
                }
            }
        }

        public bool Contains(int num)
        {
            bool present = true;
            if (this.Number == num)
            {
                present = true;
            }
            else if((this.left == null || this.left.Contains(num) == false) && (this.right == null || this.right.Contains(num)==false))
            {
                present = false;
            }

            return present;
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
            this.rootNode.Add(new TreeNode(numberData[mid]));
            if (lpointer < rpointer)
            {
                
                //Add to the right
                AddMid(numberData, mid + 1, rpointer);
                //Add to the Left
                AddMid(numberData, lpointer, mid - 1);
            }
            

        }

       public bool Contains(int num)
        {
            return this.rootNode.Contains(num);
        }
    }

    
}
