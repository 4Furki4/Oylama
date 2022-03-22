namespace Oylama
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
    }
}