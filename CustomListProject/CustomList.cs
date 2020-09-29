using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class CustomList<T>
    {
        //member variables
        private T[] myCustomList;
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
                return myCustomList[i];
            }
            set
            {
                myCustomList[i] = value;
            }
        }


        // constructor
        public CustomList()
        {
            capacity = 4;
            customList = new T[capacity];
            count = ;
            

        }


        // member methods

    }
}
