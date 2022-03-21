using System;

namespace Oylama
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj() //Bu ilk mesajla hem konsolun amacı hakkında hem de seçilecek işlemler hakkında bilgi verdim.
        {
            Console.WriteLine("Merhabalar. Dizi, film ve oyun kategorilerinden herhangi birini seçip oylamaya katılabilirsiniz"+ 
            "veya sisteme yeni bir kullanıcı kaydedebilirsiniz.\n"+
            "Diziler(1)\nFilmler(2)\nOyunlar(3)\nYeni kullanıcı kaydetme(4)\nLütfen cevabınızı giriniz:");
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
    }
}