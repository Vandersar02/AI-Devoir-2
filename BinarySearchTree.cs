using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Devoir2
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private TreeNode InsertRec(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }

            if (root.Left == null)
            {
                root.Left = new TreeNode(value);
                return root;
            }
            else if (root.Right == null)
            {
                root.Right = new TreeNode(value);
                return root;
            }

            if (IsFull(root.Left))
                InsertRec(root.Right, value);
            else
                InsertRec(root.Left, value);

            return root;
        }
        private bool IsFull(TreeNode node)
        {
            return node.Left != null && node.Right != null;
        }

        public void Clear()
        {
            Root = null;
        }

    }
}
