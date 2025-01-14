namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;

            Console.WriteLine("digite um numéro;");
                num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite outro numero");
                num2 = Convert.ToInt32(Console.ReadLine());

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = 35;

            num3 = num1 + num2;


            Console.WriteLine("A soma de {0} + {1} = {2}", num1, num2, num3);
            num3 = num1 + num2;
            Console.WriteLine("A soma de {0} - {1} = {2}", num1, num2, num3);
            num3 = num1 - num2;
            Console.WriteLine("A soma de {0} * {1} = {2}", num1, num2, num3);
            num3 = num1 * num2;
            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num4, resposta);
            num3 = num1 / num2;
            num4 = 35f;
            resposta = num1 / num4;
            
        }
    }
}
