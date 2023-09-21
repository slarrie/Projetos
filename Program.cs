using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();
            String resposta = "S";

            while (resposta != "N") 
            {
                Console.Clear();
                Console.WriteLine("A hora do Pitch");
                Console.Write("Informe o minuto do pitch: ");
                int tempo = Convert.ToInt32(Console.ReadLine());
                alarme.Tempo = tempo;
                Console.WriteLine("Tempo iniciado...");
                alarme.Iniciar();
                Console.WriteLine("O seu tempo acabou!!!");
                Console.WriteLine("Deseja executar o programa novamente? S/N");
                resposta = Console.ReadLine().ToUpper();
            }
        }
    }
}
