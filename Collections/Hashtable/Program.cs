using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;


namespace @Hashtable
{
    class Program
    {
        static void Main(string[] args)
        { 
            Hashtable             Hashtable weeks = new Hashtable();
            weeks.Add("1", "SunDay");
            weeks.Add("2", "MonDay");
            weeks.Add("3", "TueDay");
            weeks.Add("4", "WedDay");
            weeks.Add("5", "ThuDay");
            weeks.Add("6", "FriDay");
            weeks.Add("7", "SatDay");
            //Display a single Item 

            MessageBox.Show(weeks["5"].ToString ());
            //Search an Item 
            if (weeks.ContainsValue("TueDay"))
            {
                MessageBox.Show("Find");
            }
            else
            {
                MessageBox.Show("Not find");
            }
            //remove an Item 
            weeks.Remove("3");
            //Display all key value pairs
            foreach (DictionaryEntry day in weeks )
            {
                MessageBox.Show (day.Key + "   -   " + day.Value );
            }
        }
        }
    }
}
