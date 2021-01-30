using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5_GameProject
{
    class ProductManager
    {
        DRY dry = new DRY();
        OrderList<string> orderList1 = new OrderList<string>();

        public void Add (Accounts account, Product product)
        {
            orderList1.Add(product.ProductName);
            dry.AccountOwner(account);
            Console.WriteLine(product.ProductName + " sepetinize eklendi.");
        }
        public void Show(Accounts account)
        {
            dry.AccountOwner(account);
            Console.WriteLine("Sepetinizdeki ürünler aşağıdaki gibidir:");
            foreach (var item in orderList1.FinalOrderArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
