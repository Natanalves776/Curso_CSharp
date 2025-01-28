using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace datas_27._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] messes = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
            int[] dia = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i <messes.Length; i++)
            {
                Console.WriteLine("o mês de " + messes[i] + "tem" + dia [i] + "dias");
            }
            string[] semana = { "domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sabado" };

            foreach (string dia in semana) 
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine();
            foreach (string mes in messes )
            {
                Console.WriteLine(mes);
            }

        }
    }
}
