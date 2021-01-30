using System;

namespace Odev5_GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts account1 = new Accounts
            {
                Id = 1,
                UserName = "enG1n",
                TcNo = "11111111111",
                BirthYear = "1000",
                FirstName = "Engin",
                LastName = "DEMİROĞ",
            };
            AccountManager accountManager = new AccountManager();
            accountManager.Add(account1);

            Console.WriteLine();

            GovData data1 = new GovData
            {
                TcNo = "11111111110",
                BirthYear = "1000",
                FirstName = "Engin",
                LastName = "DEMİROĞ",
            };
            
            GovData[] data = new GovData[] { data1 };

            GovDataManager govDataManager = new GovDataManager();
            govDataManager.Compare(account1, data);

            Console.WriteLine();
            
            account1.TcNo = "11111111110";
            accountManager.Update(account1);

            Console.WriteLine();

            govDataManager.Compare(account1, data);

            Console.WriteLine();

            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 15,
                ProductName = "Uçak",
                UnitPrice = 20.00,
                UnitsInStock = 5,
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(account1, product1);

            Console.WriteLine();

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 20,
                ProductName = "Halı",
                UnitPrice = 5.00,
                UnitsInStock = 105,
            };

            productManager.Add(account1, product2);

            Console.WriteLine();

            productManager.Show(account1);

            Console.WriteLine();
        }
    }
}
