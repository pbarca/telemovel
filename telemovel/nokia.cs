using System;

namespace telemovel
{
    internal class nokia
    {
        private int numero;

        public string Num
        {
            get => numero.ToString();
            set
            {
                int hi = 0;
                int lo = 0;
                // valor é o número do botão (posição 6). O 48 é o código ASCII do 0.
                int valor = value[6] - 48;
                switch (valor)
                {
                    case 0: hi = 1336; lo = 941; break;
                    case 1: hi = 1209; lo = 697; break;
                    case 2: hi = 1336; lo = 697; break;
                    case 3: hi = 1477; lo = 697; break;
                    case 4: hi = 1209; lo = 770; break;
                    case 5: hi = 1336; lo = 770; break;
                    case 6: hi = 1477; lo = 770; break;
                    case 7: hi = 1209; lo = 852; break;
                    case 8: hi = 1336; lo = 852; break;
                    case 9: hi = 1477; lo = 852; break;
                }
                Console.Beep(lo, 100);
                Console.Beep(hi, 100);
                if (numero.ToString().Length < 9)
                {
                    numero = numero * 10 + valor;
                }
            }
        }

        internal void reset()
        {
            numero = 0;
        }

        internal void chamar()
        {
            System.IO.Stream str = Properties.Resources.tones;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
    }
}