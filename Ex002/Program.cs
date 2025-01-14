namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            float num = 4.500f;
            char letra = 'C';
            string nome = "Khan";


            Console.WriteLine("O numero destinado é {0}.",numero);
            Console.WriteLine("O valor é R${0}." ,num);
            Console.WriteLine("A letra a seguir é {0}.",letra);
            Console.WriteLine("Seu nome é {0}.",nome);
            Console.WriteLine("O numero é {0}, o valor é r${1}, a letra é {2}, e seu nome é {3},", numero, num, letra, nome);
        }
       
    }
}
