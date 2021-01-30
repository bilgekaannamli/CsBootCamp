using System;
using System.Collections.Generic;
using System.Text;

namespace FastTry
{
    class ListManager
    {
        public string[] Add(string[] existedArray, string newmember)
        {
            string[] MyArray = new string[existedArray.Length+1];
            for (int i = 0; i < existedArray.Length; i++)
            {
                MyArray[i] = existedArray[i];
            }
            MyArray[existedArray.Length+1] = newmember;
            return MyArray;
        }
    }
}
