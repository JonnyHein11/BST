//Programmer: Jonathan Hein (11532242)
//Project: Cpts 321 HW4
//Date: 09/23/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTTree_Jonathan_Hein
{
    public class BSTree<T> : BinTree<T>
    {
        int counter = 0;
        int maxlevel = 0;
        int level = 0;

        private Node<T> root = null;
        

        public override void Insert(T val) // Insert new item of type T
        {
            if(root == null)
            {
                root = new Node<T>();
                root.Data = val;
                counter++;
                maxlevel = 1;
            }
            else if (Contains(val)) // checks to see if value is in tree
            {
                return;
            }
            else
            {
                level = 1;
                Node<T> newNode = new Node<T>();
                newNode.Data = val;
                insertToBST(this.root, newNode);
                if (maxlevel < level)
                {
                    maxlevel = level;
                }
            }
        }
        private void insertToBST(Node<T> current, Node<T> newnode)
        {
            if (current > newnode)
            {
                if (current.left == null)
                {
                    current.left = newnode;
                    counter++;
                    level++;
                }
                else
                {
                    insertToBST(current.left, newnode);
                    level++;
                }
            }
            else
            {
                if (current.right == null)
                {
                    current.right = newnode;
                    counter++;
                    level++;
                }
                else
                {
                    insertToBST(current.right, newnode);
                    level++;
                }
            }
        }
        public override bool Contains(T val) // Returns true if item is in tree
        {
            Node<T> temp = new Node<T>();
            temp.Data = val;
            return containsHelper(root, temp);
        }
        // since i have overrided comparable operators, it is necessary to create a temp node for 
        // the value being tested and traverse through the list. 
        private bool containsHelper(Node<T> trav, Node<T> Temp)
        {
            bool flag = false; // assume not in list
            if (trav == Temp)
            {                   // if traversed node is equivalent to temp we set flag to true
                flag = true;
                return flag;
            }
            else if (trav < Temp && trav.right != null)
            {
                flag = containsHelper(trav.right, Temp);
                return flag;
            }
            else if (trav > Temp && trav.left != null)
            {
                flag = containsHelper(trav.left, Temp);
                return flag;
            }
            else
            {
                flag = false; // if not found we set flag to false
                return false;
            }
        }
        public override void InOrder()
        {
            Console.Write("Tree Contents:");
            inorderTraversal(root);
        }
        static void inorderTraversal(Node<T> current)
        {
            if (current != null)
            {
                inorderTraversal(current.left);
                Console.Write(" " + current.Data);
                inorderTraversal(current.right);
            }
        }
        public void PrintTreeStat()
        {
            Console.Write("\nTree Statistics:");
            BSTcount();
            BSTlevel();
            BSTTheoLevel();
        }
        public override void PreOrder()
        {
        }
        public override void PostOrder()
        {
        }

        public void BSTcount()
        {
            Console.Write("\n Number of node's: " + counter);
        }
        public void BSTlevel()
        {
            Console.Write("\n Number of Levels: " + level);
        }
        public void BSTTheoLevel()
        {
            Console.Write("\n Minimum num of levels that a tree with " + counter + " nodes should have: " + (Math.Floor(Math.Log(2 * counter, 2.0)))); //floor(log_2(2n))
        }

    }
}
