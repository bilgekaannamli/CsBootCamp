using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5_GameProject
{
    class AccountManager
    {
        DRY dry = new DRY();
        public void Add(Accounts account)
        {
            dry.AccountOwner(account);
            Console.WriteLine("Hesabınız " + '"' + account.UserName + '"' + " kullanıcı adınızla oluşturuldu!");
        }
        public void Update(Accounts account)
        {
            dry.AccountOwner(account);
            Console.WriteLine("Kaydınız güncellendi!");
        }
        public void Delete(Accounts account)
        {
            dry.AccountOwner(account);            
            Console.WriteLine('"' + account.UserName + '"' + 
                " kullanıcı adlı hesabınız silindi. Veri güvenliğinize saygı duyarız.");
        }
    }
}
