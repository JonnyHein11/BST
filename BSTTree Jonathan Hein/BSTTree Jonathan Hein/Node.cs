//Programmer: Jonathan Hein (11532242)
//Project: Cpts 321 HW4
//Date: 09/23/2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BSTTree_Jonathan_Hein
{

    public class Node<T>
    {
        public T Data;
        public Node<T> right;
        public Node<T> left;


        public static bool operator ==(Node<T> a, Node<T> b)
        {
            if (System.Object.ReferenceEquals(a,b)) // https://docs.microsoft.com/en-us/dotnet/api/system.object.referenceequals?view=netframework-4.7.2
            {
                return true;
            }
            if ((object)a==null||(object)b==null)
            {
                return false;
            }
            return (Comparer.Default.Compare(a.Data, b.Data) == 0); // https://docs.microsoft.com/en-us/dotnet/api/system.collections.comparer.compare?view=netframework-4.7.2
        }
        // Overided != operator 
        public static bool  operator !=(Node<T> a, Node<T> b)
        {
            if ((Object)a != null && (object)b == null) // if x != null
            {
                return true;
            }
            if ((object)a == null || (object)b == null)
            {
                return false;
            }
            return !(Comparer<T>.Default.Compare(a.Data, b.Data) == 0);
        }
        public override bool Equals(object obj)
        {
            if (this == null || obj == null)
            {
                return false;
            }
            Node<T> temp = (Node<T>)obj;
            return ((Comparer<T>.Default.Compare(this.Data, temp.Data)) == 0);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        // Overided >= operator
        public static bool operator >=(Node<T> a, Node<T> b)
        {
            if ((Comparer<T>.Default.Compare(a.Data,b.Data) > 0) || (Comparer<T>.Default.Compare(a.Data, b.Data) == 0)) // a greater than b
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Overided <= operator 
        public static bool operator <=(Node<T> a, Node<T> b)
        {
            if ((Comparer<T>.Default.Compare(a.Data, b.Data) < 0) || (Comparer<T>.Default.Compare(a.Data, b.Data) == 0)) // a less than b
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Overided > operator
        public static bool operator >(Node<T> a, Node<T> b)
        {
            if ((object)a == null || (object)b == null)
            {
                return false;
            }
            if (Comparer<T>.Default.Compare(a.Data, b.Data) > 0) // a greater than b
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Overided < operator 
        public static bool operator <(Node<T> a, Node<T> b)
        {
            if ((object)a == null || (object)b == null)
            {
                return false;
            }
            if (Comparer.Default.Compare(a.Data, b.Data) < 0) // a less than b
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
