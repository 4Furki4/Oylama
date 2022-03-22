using System;
using System.Globalization;

namespace Oylama.Karegoriler
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
        public void OylamaDurumu()
        {
            int toplamOy= HIMYM+BreakingBad+PrisonBreak+BlackMirror;
            string HIMYM_yuzde= (HIMYM/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string BreakingBad_yuzde=(BreakingBad/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string PrisonBreak_yuzde=(PrisonBreak/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            string BlackMirror_yuzde=(BlackMirror/toplamOy).ToString("P",CultureInfo.InvariantCulture);
            Console.WriteLine("Rakamsal ve yüzdesel olarak dizilerin oy durumları aşağıdaki gibidir:"+
            $"HIMYM oyu: {HIMYM} {HIMYM_yuzde} \n"+
            $"Breaking Bad oyu: {BreakingBad} {BreakingBad_yuzde} \n"+
            $"Prison Break oyu: {PrisonBreak} {PrisonBreak_yuzde} \n"+
            $"Black Mirror oyu: {BlackMirror} {BlackMirror_yuzde}");
        }
        
    }
}