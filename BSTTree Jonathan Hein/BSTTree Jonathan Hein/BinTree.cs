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
    public abstract class BinTree<T>
    {
        public abstract void Insert(T val); // Insert new item of type T
        public abstract bool Contains(T val); // Returns true if item is in tree
        public abstract void InOrder(); // Print elements in tree inorder traversal
        public abstract void PreOrder(); // maybe used in future? not required in result for abstract tree hw
        public abstract void PostOrder();
    }
}
