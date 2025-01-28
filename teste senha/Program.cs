namespace teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhadigitada;
            int tentativas = 0;
            do
            {
                Console.Clear();
                Console.Write("digite a senha:  ");
                senhadigitada = Console.ReadLine();
                tentativas++;
                if (tentativas < 3) { break; }
            } while (senha != senhadigitada);


            if (senha != senhadigitada)
            {
                Console.Clear();
                Console.WriteLine("senha correta! tentativas: " + tentativas);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("senha correta! tentativas: " + tentativas);
            }
        }
    }
}
