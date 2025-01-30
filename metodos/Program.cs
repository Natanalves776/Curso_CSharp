using System.Data;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            saudacao("Khan");
        }

        static void soma( int a, int b) // metodos 
        {
            int resultado = a + b;
            Console.WriteLine("A soma de " + a + " + " + b + " = " + resultado);
        }

        static void saudacao(string nome)
        {
            Console.WriteLine(nome + ". Olá......abobado");
        }
    }
}
