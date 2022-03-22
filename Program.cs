using System;
using System.Collections.Generic;

namespace Oylama
{
    class Program
    {
        static void Main(string[] args)
        {   
            Kullanıcı _kullanıcı= new Kullanıcı();
            Konsol_Islemleri konsol= new Konsol_Islemleri();
            List<Kullanıcı> kullanıcılar = new List<Kullanıcı>(); // 4 tane varsayılan kullanıcı atadım.
            kullanıcılar.Add(new Kullanıcı("Furkan"));
            kullanıcılar.Add(new Kullanıcı("Betül"));
            kullanıcılar.Add(new Kullanıcı("Semiha"));
            kullanıcılar.Add(new Kullanıcı("Aybüke"));
            bool devam=true;
            while (devam)
            {
                System.Console.WriteLine("Lütfen kullanıcı isminizi giriniz:\n");
                string input= Console.ReadLine().Trim();
                foreach (var kullanıcı in kullanıcılar)
                {
                    if (kullanıcı.Username==input)
                    {
                        
                    }
                    else
                    {
                        System.Console.WriteLine("Girmiş olduğunuz kullanıcı ismi bulunamadı.\n"+
                        "Çıkış yapmak istiyorsanız (1), yeni kullanıcı eklemek istiyorsanız (2) yazınız.");
                        if (Console.ReadLine()=="1")
                        {
                            System.Console.WriteLine("Konsol işleminden çıkılıyor, tekrar görüşmek üzere...");
                            devam=false;
                        }else if (Console.ReadLine()=="2")
                        {
                            _kullanıcı.KullanıcıKaydet(kullanıcılar, konsol.Kullanıcı_ismi_alma());
                        }
                    }
                }
            }
        }
    }
}
