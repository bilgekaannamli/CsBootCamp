using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5_GameProject
{
    class DRY
    {
        public void AccountOwner(Accounts account)
        {
            Console.WriteLine("Sayın " + account.FirstName + " " + account.LastName + ",");
        }
        public void Failure(string item)
        {
            Console.WriteLine(item + " hatalıdır!");
        }
    }
}
