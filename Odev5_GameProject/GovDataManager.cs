using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5_GameProject
{
    class GovDataManager
    {
        DRY dry = new DRY();
        public void Compare(Accounts account, GovData[] data)
        {
            foreach (var i in data)
            {
                if (String.Equals(account.TcNo, i.TcNo))
                {
                    if (String.Equals(account.BirthYear, i.BirthYear))
                    {
                        if (String.Equals(account.FirstName, i.FirstName))
                        {
                            if (String.Equals(account.LastName, i.LastName))
                            {
                                Console.WriteLine("Bilgileriniz E-devlet üzerinden doğrulandı!");
                            }
                            else
                            {
                                dry.Failure(account.LastName);
                            }
                        }
                        else
                        {
                            dry.Failure(account.FirstName);
                        }
                    }
                    else
                    {
                        dry.Failure(account.BirthYear);
                    }
                }
                else
                {
                    dry.Failure(account.TcNo);
                }
            }
        }
    }
}
