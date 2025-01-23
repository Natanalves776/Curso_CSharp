namespace ex_15_ed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("digite o genero:  ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "f" && genero != "m")
            {
                Console.Write("digite o genero:  ");
                genero = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-Vindo e Bem-Vinda ao curso de c#");

        }
        




    }
}
