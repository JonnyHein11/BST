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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter List of Integers:");
            string line = Console.ReadLine();
            string[] splitLine = line.Split(' ');
            BSTree<int> My_BSTree = new BSTree<int>();
            for (int i = 0; i < splitLine.Length; i++)  //stores the string "splitLine" (containing inputted values) for all values
            {
                My_BSTree.Insert(Convert.ToInt32(splitLine[i])); //converts char values in splitline into integers and stores in My_BSTree
            }

            My_BSTree.InOrder();
            My_BSTree.PrintTreeStat();
            Console.ReadLine(); //Just to pause
        }
    }

}