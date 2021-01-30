using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kaan");

            Console.WriteLine(isimler.MyLength);
            foreach (var item in isimler.MYArray)
            {
                Console.WriteLine(item);
            }
            
            isimler.Add("Kaan");

            Console.WriteLine(isimler.MyLength);
            foreach (var item in isimler.MYArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
