namespace impresao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static void escreva(string[] texto)
        {
           char caracter = '=';
            int tamanho = texto.Length + 4;
            string linha = new string(caracter, tamanho);
            Console.WriteLine(linha);
            Console.WriteLine(texto);
            Console.WriteLine(linha);

        }
    }
}
