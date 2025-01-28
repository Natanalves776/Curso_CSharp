namespace vetores_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int[] num = new int[5];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;

            Console.WriteLine(num[1]);

            int[] n = new int[3] { 1, 2, 3, };
           
            Console.WriteLine(n[2]);

            int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,};

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numero[i] + " " + i);
            }
          

            double[] reais = { 4.5, 3.2, 7.85, 10.64, -5.43, -2.1, -9 };
            for (int i = 0; i < reais.Length; i++)
            {
                Console.WriteLine(reais[i]);
            }

            double reais_maior = reais.Max();
            double reais_menor = reais.Min();

            Console.WriteLine("o maior valor é: " + reais_maior);
            Console.WriteLine("o menor valor é: " + reais_menor);
            */

            string[] nomes = { "maria","joão","matheus","mikael","julia","marina","zeferina" };

            for (int i = 0; i < nomes.Length; i++)

            {
                if (i < nomes.Length - 1)
                { Console.Write(nomes[i] + ", ");}
                else
                {
                    Console.WriteLine(nomes[1] + ".");
                }
            }

            Console.WriteLine();
            string nome_primeiro = nomes.First();
            string nome_ultimo = nomes.Last();
            Console.WriteLine("O primeiro nome é:  " + nome_primeiro);
            Console.WriteLine("O ultimo nome é:  " + nome_ultimo);
            Console.WriteLine();
            string nomes_maior = nomes.Max();
            string nomes_menor = nomes.Min();
            Console.WriteLine("O primeiro nome em ordem alfabetica é:   " + nomes_menor);
            Console.WriteLine("o ultimo nome em ordem alfabetica é:  " + nomes_maior);
            Console.WriteLine();



        }

    }
}
