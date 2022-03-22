using System;
using System.Globalization;

namespace Oylama.Karegoriler
{
    public class Filmler
    {
        private int theBatman;
        private int greenBook;
        private int driveMyCar;
        private int theLordOfTheRings;

        public int TheBatman { get => theBatman; set => theBatman = value; }
        public int GreenBook { get => greenBook; set => greenBook = value; }
        public int DriveMyCar { get => driveMyCar; set => driveMyCar = value; }
        public int TheLordOfTheRings { get => theLordOfTheRings; set => theLordOfTheRings = value; }

        public void FilmOyla(int secilen)
        {
            switch (secilen)
            {
                case 1:
                    TheBatman++;
                    break;
                case 2:
                    GreenBook++;
                    break;
                case 3:
                    DriveMyCar++;
                    break;
                case 4:
                    TheLordOfTheRings++;
                    break;
            }
        }
        public void OylamaDurumu()
        {
            int toplamOy= TheBatman+GreenBook+DriveMyCar+TheLordOfTheRings;
            string TheBatman_yuzde= (TheBatman/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string GreenBook_yuzde=(GreenBook/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string DriveMyCar_yuzde=(DriveMyCar/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string TheLordOfTheRings_yuzde=(TheLordOfTheRings/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            Console.WriteLine("Rakamsal ve yüzdesel olarak filmlerin oy durumları aşağıdaki gibidir:"+
            $"The Batman oyu: {TheBatman} {TheBatman_yuzde} \n"+
            $"Green Book oyu: {GreenBook} {GreenBook_yuzde} \n"+
            $"Drive My Car oyu: {DriveMyCar} {DriveMyCar_yuzde} \n"+
            $"The Lord Of The Rings oyu: {TheLordOfTheRings} {TheLordOfTheRings_yuzde}");
        } 
    }
}