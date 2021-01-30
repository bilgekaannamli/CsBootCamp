using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 10;
            int Number2 = 30;
            Number1 = Number2;
            Number2 = 65;
            Console.WriteLine(Number1);
            //Number1 = 30 basar.

            int[] NumberSet1 = new int[] { 10, 20, 30 };
            int[] NumberSet2 = new int[] { 100, 200, 300 };
            NumberSet1 = NumberSet2;
            NumberSet2[0] = 999;
            Console.WriteLine(NumberSet1[0]);
            //NumberSet1[0] = 999 basar.
        }
    }
}
