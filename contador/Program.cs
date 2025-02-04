namespace contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contagem(1, 10, 1);
            contagem(10, 0, 2);

            escrever(" agora e sua vez de fazer a montagem ");
            Console.Write("digite o inicio da contagem ");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("digite o fim da contagem ");
            int fim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("digite o passo da contagem ");
            int passo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            contagem(ini, fim, passo);
        }

        static void contagem(int i, int f, int p)
        {
            escrever($"contagem de {i} até {f} de {p} em {p}.  ");
            if (p < 0)
            {
                p *= -1;
            }



            if (i < f)
            {
                int cont = i;
                while (cont <= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500); //  contador de segundo do computador 
                    cont += p;
                }
                Console.WriteLine("FIM!");

            }
            else
            {

                if (i < f)
                {
                    int cont = i;
                    while (cont >= f)
                    {
                        Console.Write(cont + " ");
                        Thread.Sleep(500);
                        cont -= p;
                    }
                    Console.WriteLine("FIM!");


                }
            }
        }
            static void escrever(string texto)
            {

                int tam = texto.Length + 4;
                string linha = new string('=', tam);
                string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 1);
                Console.WriteLine(linha);
                Console.WriteLine($"| {textoCentralizado} |");
                Console.WriteLine(linha);
            }
        
    }
}

            