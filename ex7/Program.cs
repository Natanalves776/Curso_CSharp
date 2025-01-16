namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
           
          

          float resposta;

            Console.WriteLine("nota numero 1 ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nota numero 2 ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            resposta = (nota1 + nota2) / 2;


            Console.WriteLine("a media é {0}",resposta);
       
               
        }
    }
}
