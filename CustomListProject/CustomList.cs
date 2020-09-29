using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        private T[] myCustomArray;
        private int count;
        private int capacity;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this[int i]
        {
            get
            {
                return myCustomArray[i];
            }
            set
            {
                myCustomArray[i] = value;
            }
        }


        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            myCustomArray = new T[capacity];
        }


        // member methods
        public void Add(T numberAdded )
        {
            if (capacity == count)
            {
                T[]temporaryArray = new T[capacity];
                temporaryArray = myCustomArray;
                myCustomArray = new T[capacity *= 2];
                for (int i = 0; i < temporaryArray.Length; i++)
                {
                    myCustomArray[i] = temporaryArray[i];
                }
                
                
                

            }
            //what should the array look like after we exit that if statement?
            myCustomArray[Count] = numberAdded;
            Count++;
        }

    }
}
