using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 0;
            ArrayList ItemList = new ArrayList();
            ItemList.Add("dotnet");
            ItemList.Add("asp");
            ItemList.Add("vb");
            ItemList.Add("java");
            ItemList.Add("c-sharp");
            Console.WriteLine("Shows Added Items");
            for (i = 0; i <=ItemList.Count - 1; i++)
            {
                Console.WriteLine(ItemList[i].ToString());
            }
            //insert an item 
            ItemList.Insert(3, "Mainframe");
            //sort itemms in an arraylist 
            ItemList.Sort();
            //remove an item 
            ItemList.Remove("Item1");
            //remove item from a specified index 
            ItemList.RemoveAt(3);
            Console.WriteLine();
            for (i = 0; i <= ItemList.Count - 1; i++)
            {
                Console.WriteLine(ItemList[i].ToString());
            }
            //reverse
            ItemList.Reverse();
            Console.WriteLine();
            for (i = 0; i <= ItemList.Count - 1; i++)
            {
                Console.WriteLine(ItemList[i].ToString());
            }

            Console.WriteLine();
            ItemList.RemoveRange(0, 1);

            for (i = 0; i <= ItemList.Count - 1; i++)
            {
                Console.WriteLine(ItemList[i].ToString());
            }


            Console.ReadKey();

        }
    }
}
