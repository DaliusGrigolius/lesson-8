using System;

namespace _8_lesson_8.Business
{
    public struct Saskaita
    {
        public string Gavejas { get; }
        public string Siuntejas { get; }
        public double MoketiViso { get; }
        public string SaskaitosNumeris { get; private set; }

        public Saskaita(string gavejas, string siuntejas, double moketiViso)
        {
            Gavejas = gavejas;
            Siuntejas = siuntejas;
            MoketiViso = moketiViso;
            SaskaitosNumeris = $"NR_{DateTime.Now.ToString("yyyy_MM_dd")}_01";
        }   
        
        public void ModifyAccNumber(string saskaitosNumeris)
        {
            SaskaitosNumeris = saskaitosNumeris;
        }
    }
}
