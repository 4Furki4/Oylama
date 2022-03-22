using System;
using System.Collections.Generic;
using Oylama.Karegoriler;

namespace Oylama
{
    class Program
    {
        static void Main(string[] args)
        {   
            Diziler diziler = new Diziler();
            Oyunlar oyunlar = new Oyunlar();
            Filmler filmler = new Filmler();
            Kullanıcı _kullanıcı= new Kullanıcı();
            Konsol_Islemleri konsol= new Konsol_Islemleri();
            List<Kullanıcı> kullanıcılar = new List<Kullanıcı>(); // 4 tane varsayılan kullanıcı atadım.
            kullanıcılar.Add(new Kullanıcı("Furkan"));
            kullanıcılar.Add(new Kullanıcı("Betül"));
            kullanıcılar.Add(new Kullanıcı("Semiha"));
            kullanıcılar.Add(new Kullanıcı("Aybüke"));
            Konsol_Kullanımı(_kullanıcı, konsol, kullanıcılar, diziler, filmler, oyunlar);
            static void Konsol_Kullanımı(Kullanıcı _kullanıcı, Konsol_Islemleri konsol, List<Kullanıcı> kullanıcılar, Diziler diziler, Filmler filmler, Oyunlar oyunlar)
            {
                bool devam=true;
                while (devam)
            {
                System.Console.Write("Lütfen kullanıcı isminizi giriniz:");
                string input= Console.ReadLine().Trim();
                foreach (var kullanıcı in kullanıcılar)
                {
                    if (kullanıcı.Username==input)
                    {
                        konsol.IlkMesaj();
                        int islemNo=konsol.IslemSecme();
                        switch (islemNo)
                        {
                            case 1:
                                konsol.DiziSecenekleri();
                                int diziOyu=int.Parse(Console.ReadLine()); 
                                diziler.DiziOyla(diziOyu);
                                Konsol_Kullanımı(_kullanıcı, konsol, kullanıcılar, diziler, filmler, oyunlar);
                                break;
                            case 2:
                                konsol.FilmSecenekleri();
                                int filmOyu= int.Parse(Console.ReadLine());
                                filmler.FilmOyla(filmOyu);
                                Konsol_Kullanımı(_kullanıcı, konsol, kullanıcılar, diziler, filmler, oyunlar);
                                break;
                            case 3:
                                konsol.OyunSecenekleri();
                                int oyunOyu=int.Parse(Console.ReadLine());
                                oyunlar.FilmOyla(oyunOyu);
                                Konsol_Kullanımı(_kullanıcı, konsol, kullanıcılar, diziler, filmler, oyunlar);
                                break;
                            case 4:
                                string kullanıcıIsmi=konsol.Kullanıcı_ismi_alma();
                                _kullanıcı.KullanıcıKaydet(kullanıcılar,kullanıcıIsmi);
                                Konsol_Kullanımı(_kullanıcı, konsol, kullanıcılar, diziler, filmler, oyunlar);
                                break;
                            case 5:
                                diziler.OylamaDurumu();
                                filmler.OylamaDurumu();
                                oyunlar.OylamaDurumu();
                                Konsol_Kullanımı(_kullanıcı, konsol, kullanıcılar, diziler, filmler, oyunlar);
                                break;
                            case 6:
                                devam=false;
                                break;
                        }
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
}
