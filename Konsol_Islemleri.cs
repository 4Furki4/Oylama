using System;
using System.Collections.Generic;
using Oylama.Karegoriler;

namespace Oylama
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj() //Bu ilk mesajla hem konsolun amacı hakkında hem de seçilecek işlemler hakkında bilgi verdim.
        {
            Console.WriteLine("Merhabalar. Dizi, film ve oyun kategorilerinden herhangi birini seçip oylamaya katılabilirsiniz"+ 
            "veya sisteme yeni bir kullanıcı kaydedebilirsiniz.\n"+
            "Diziler(1)\nFilmler(2)\nOyunlar(3)\nYeni kullanıcı kaydetme(4)\nOy durumunu inceleme(5)\nÇıkış yapmak için(6)\nLütfen cevabınızı giriniz:");
        }
        public void KategoriMesajı()
        {
            
        }
        public int IslemSecme() // switch-case yapısında kullanacağım, ilk mesajda kullanıcından istediğim işlem numarasını döndüren metot.
        {
            return Convert.ToInt16(Console.ReadLine());
        }
        public string Kullanıcı_ismi_alma() //yeni bir kullanıcı kaydederken kullanıcıdan username alan ve döndüren metot.
        {
            Console.WriteLine("Lütfen kaydetmek istediğiniz kişinin username'ini giriniz.");
            return Console.ReadLine();
        }
        public void DiziSecenekleri()
        {
            // HIMYM Breaking Bad Prison Break Black Mirror
            System.Console.WriteLine("Lütfen oy vermek istediğiniz diziyi seçiniz:\n"+
            "How I Met Your Mother(1)"+
            "Breaking Bad(2)"+
            "Prison Break(3)"+
            "Black Mirror(4)");
        }
        public void FilmSecenekleri()
        {
            System.Console.WriteLine("Lütfen oy vermek istediğiniz filmi seçiniz:\n"+
            "The Batman(1)"+
            "Green Book(2)"+
            "Drive My Car(3)"+
            "The Lord Of The Rings(4)");
        } // Green Book Drive My Car The Lord Of The Rings
        public void OyunSecenekleri()
        {
            System.Console.WriteLine("Lütfen oy vermek istediğiniz oyunu seçiniz:\n"+
            "Red Dead Redemption 2(1)\n"+
            "Crysis 3(2)\n"+
            "God Of War(3)\n"+
            "Sekiro(4)");
        }//  Crysis 3 God Of War Sekiro
        
            
    }
}