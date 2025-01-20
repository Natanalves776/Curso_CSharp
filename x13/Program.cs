using System.ComponentModel.Design;

namespace x13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write(" digite o valor do lado A:  ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write(" digite o valor do lado B:  ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write(" digite o valor do lado c:  ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))


            {
                Console.WriteLine(" os valores informados forman um triangulo ");
            }




            else
            {
                Console.WriteLine("os valores informados não foram um trinangulo");
            }

        }
    }
}
