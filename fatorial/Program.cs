namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char resp;
            bool mostrar = false;

            Console.Write("digite um numero inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("deseja mostra os calculos? (s/n)");
            resp = Convert.ToChar(Console.ReadLine().ToLower()); // sempre que usar TOlower sempre deixara as letras minusculas..
            Console.WriteLine();

            if (resp == 's') { mostrar = true; }

            Console.WriteLine(fatorial(num, mostrar));




        }

        static int fatorial(int n, bool show= false)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.Write(i);
                    if (i < n)
                    {
                        Console.Write(" x ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }
                f *= i; // esse F representa o fatorial repetitivo até o numero 1 
            }
            return f; // sempre que usar int no static deve se por esse codigo return no final.
        }
    }
}
