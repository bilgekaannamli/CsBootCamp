using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5_GameProject
{
    class OrderList<T>
    {
        T[] OrderArray;
        //constructor
        public OrderList()
        {
            OrderArray = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = OrderArray;
            OrderArray = new T[OrderArray.Length + 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                OrderArray[i] = tempArray[i];
            }
            
            OrderArray[OrderArray.Length - 1] = item;
            
        }
        //Henüz öğrenilmemişler
        public int OrderLength
        {
            get { return OrderArray.Length; }
        }
        public T[] FinalOrderArray
        {
            get { return OrderArray; }
        }
    }
}
