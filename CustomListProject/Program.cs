using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // make two customlist objects
            // make a third list, that is equal to list1 + list2;
            CustomList<string> customArrayOne = new CustomList<string>();
            customArrayOne.Add("cats");
            customArrayOne.Add("are");
            customArrayOne.Add("the");
            CustomList<string> CustomArrayTwo = new CustomList<string>();
            CustomArrayTwo.Add("best");
            CustomArrayTwo.Add("pets");
            CustomList<string> resultArray = new CustomList<string>();
            resultArray = customArrayOne + CustomArrayTwo;
            string result = resultArray.ToString();
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
