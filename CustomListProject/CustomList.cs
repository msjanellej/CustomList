﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
        public void Add(T numberAdded)
        {
            if (capacity == count)
            {
                T[] temporaryArray = new T[capacity];
                temporaryArray = myCustomArray;
                myCustomArray = new T[capacity *= 2];
                for (int i = 0; i < temporaryArray.Length; i++)
                {
                    myCustomArray[i] = temporaryArray[i];
                }
            }
            myCustomArray[Count] = numberAdded;
            Count++;
        }
        public bool Remove(T itemToRemove)
        {
            T[] temporaryArray = new T[capacity];
            bool itemFound = false;
            for (int i = 0; i < myCustomArray.Length; i++)
            {
                if (!myCustomArray[i].Equals(itemToRemove) && itemFound == false)
                {
                    if (itemFound == false)
                    {
                        temporaryArray[i] = myCustomArray[i];

                    }
                }
                else if (myCustomArray[i].Equals(itemToRemove) && itemFound == false)
                {
                    itemFound = true;

                    continue;
                }
                else
                {
                    temporaryArray[i - 1] = myCustomArray[i];
                }
            }
            myCustomArray = temporaryArray;
            if (itemFound)
            {
                count--;
            }
            return true;
        }
        public override string ToString()
        {
            string outputString = null;
            for (int i = 0; i < count; i++)
            {
                outputString = outputString + myCustomArray[i];
            }
            return outputString;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return myCustomArray[i];
            }
        }
        public static CustomList<T> operator +(CustomList<T> firstArray, CustomList<T> secondArray)
        {
            CustomList<T> temporaryArray = new CustomList<T>();
            for (int i = 0; i < firstArray.count; i++)
            {
                temporaryArray.Add(firstArray[i]);
            }
            for (int i = 0; i < secondArray.count; i++)
            {
                temporaryArray.Add(secondArray[i]);
            }
            return temporaryArray;
        }
        public static CustomList<T> operator -(CustomList<T> firstArray, CustomList<T> secondArray)
        {
            for (int i = 0; i < secondArray.count; i++)
            {
                firstArray.Remove(secondArray[i]);
            }
            return firstArray;
        }
        public CustomList<T> Zip(CustomList<T> secondArray)
        {
            CustomList<T> resultArray = new CustomList<T>();

            if (count >= secondArray.count)
            {
                for (int i = 0; i < count; i++)
                {
                    resultArray.Add(myCustomArray[i]);
                    if (i<secondArray.count)
                    {
                        resultArray.Add(secondArray[i]);
                    }                           
                }
            }
            else
            {
                for (int i = 0; i < secondArray.count; i++)
                {
                    if (i< count)
                    {
                        resultArray.Add(myCustomArray[i]);  
                    }
                    resultArray.Add(secondArray[i]);
                }
            }
            return resultArray;
        }
        public void Sort(CustomList<T> array)
        {
            
        }
    }
}
