namespace ex_0012_22._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.WriteLine("´´´´´´´´´´´´´´´´´´´´´´´´´´´´");
            Console.WriteLine("digite o final do intervalo");
            Console.WriteLine("´´´´´´´´´´´´´´´´´´´´´´´´´´´´");
            Console.WriteLine();

            Console.WriteLine("digite o final do intervalo");
            final = Convert.ToInt32(Console.ReadLine());
            
                for (int i = 1; i <= final; i++)
             
                if (i % 2 == 0)
            {
                    Console.Write(" {0}, ", i);
            }
        }

    }
}
