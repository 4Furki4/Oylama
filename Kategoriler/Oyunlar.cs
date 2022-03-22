using System;
using System.Globalization;

namespace Oylama.Karegoriler
{
    public class Oyunlar
    { // Oyunlarımız
        private int redDeadRedemption2; // Oyunlar kategorisinde mevcut olan oyunları int property olarak ekledim 
                                        // ve isimlerini kullanarak oy sayılarına ulaşmayı hedefliyorum
        private int crysis3;
        private int godOfWar;
        private int sekiro;

        public int RedDeadRedemption2 { get => RedDeadRedemption2; set => RedDeadRedemption2 = value; } 
        public int Crysis3 { get => Crysis3; set => Crysis3 = value; }
        public int GodOfWar { get => GodOfWar; set => GodOfWar = value; }
        public int Sekiro { get => Sekiro; set => Sekiro = value; }

        public void FilmOyla(int secilen)
        {
            switch (secilen)
            {
                case 1:
                    RedDeadRedemption2++;
                    break;
                case 2:
                    Crysis3++;
                    break;
                case 3:
                    GodOfWar++;
                    break;
                case 4:
                    Sekiro++;
                    break;
            }
        }
        
        public void OylamaDurumu()
        {
            int toplamOy= RedDeadRedemption2+Crysis3+GodOfWar+Sekiro;
            string RDR2_yuzde= (RedDeadRedemption2/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string Crysis3_yuzde=(Crysis3/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string GodOfWar_yuzde=(GodOfWar/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string Sekiro_yuzde=(Sekiro/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            Console.WriteLine("Rakamsal ve yüzdesel olarak oyunların oy durumları aşağıdaki gibidir:"+
            $"Red Dead Redemption 2 oyu: {RedDeadRedemption2} {RDR2_yuzde} \n"+
            $"Crysis 3 oyu: {Crysis3} {Crysis3_yuzde} \n"+
            $"God Of War oyu: {GodOfWar} {GodOfWar_yuzde} \n"+
            $"Sekiro oyu: {Sekiro} {Sekiro_yuzde}\n");
        }
    }
}