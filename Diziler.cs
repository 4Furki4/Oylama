namespace Oylama
{
    public class Diziler
    {
        private int himym; //1
        private int breakingBad; //2
        private int prisonBreak; //3 
        private int blackMirror; //4

        public int HIMYM { get => himym; set => himym = value; }
        public int BreakingBad { get => breakingBad; set => breakingBad = value; }
        public int PrisonBreak { get => prisonBreak; set => prisonBreak = value; }
        public int BlackMirror { get => blackMirror; set => blackMirror = value; }
        public void DiziOyla(int secilen)
        {
            switch (secilen)
            {
                case 1:
                    HIMYM++;
                    break;
                case 2:
                    BreakingBad++;
                    break;
                case 3:
                    PrisonBreak++;
                    break;
                case 4:
                    BlackMirror++;
                    break;
            }
        }
    }
}