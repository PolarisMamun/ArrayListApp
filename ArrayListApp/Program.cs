using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();  
            
            myArrayList.Add(1);
            myArrayList.Add(2.55);
            myArrayList.Add(3);
            myArrayList.Add("Hi");
            myArrayList.Add("Hello");
            myArrayList.Add(6);
            myArrayList.Add(true);
            myArrayList.Add(false);

            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < myArrayList.Count; i++)
            //{
            //    Console.WriteLine(myArrayList[i]);
            //}


            Console.ReadLine();
        }
    }
}
