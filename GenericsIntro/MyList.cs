using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] MyArray;
        //constructor
        public MyList()
        {
            MyArray = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = MyArray;
            MyArray = new T[MyArray.Length + 1];
            //NOTUM: MyArray = tempArray;
            for (int i = 0; i < tempArray.Length; i++)
            {
                MyArray[i] = tempArray[i];
            }
            //KESİNLİKLE ÇALIŞMAZ: MyArray[tempArray.Length + 1] = item;
            MyArray[MyArray.Length - 1] = item;
            //Console.WriteLine("TEMP UZUNLUK:  "+tempArray.Length);
        }
        //Henüz öğrenilmemişler
        public int MyLength
        {
            get { return MyArray.Length; }
        }
        public T[] MYArray
        {
            get { return MyArray; }
        }
    }
}
