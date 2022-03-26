using System;

namespace paskaita_8_darbas_02.Bussines
{
    public struct Palme
    {
        public int Amzius { get; private set; }
        public int VaisiuKiekis { get; private set; }

        public Palme(int amzius, int vaisiuKiekis)
        {
            Amzius = amzius;
            VaisiuKiekis = vaisiuKiekis;
        }

        public void Prideti1MenAmziaus()
        {          
            Amzius++;
            if (Amzius > 12)
            {
                Amzius = 0;
            }

            if (Amzius >= 5 && Amzius <= 12)
            {
                VaisiuKiekis = Amzius * 3;
            } else
            {
                VaisiuKiekis = 0;
            }
        }
    }
}
