using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    public class Alarme
    {
        public Alarme()
        {
            this.Tempo = 3; //três minutos
        }

        public Alarme(int tempo)
        {
            this.Tempo = tempo;
        }

        //Controla do tempo do Pitch
        private int tempo;

        public int Tempo
        {
            get { return tempo; }
            set { tempo = 1000 * 60 * value; } //Calculo para converter segundo em minuto.
        }

        public void Iniciar()
        {
            Thread.Sleep(this.Tempo);
            Console.Beep(400,2000);
        }
    }
}
