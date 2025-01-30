namespace area___terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Cálcular a Área do terreno");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Digite a largura do terreno(m)");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a comprimento do terreno(m)");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(l, c);


        }
        static void area(double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($"A area do terreno de {largura} x {comprimento} é de {a:F2}m²"); // METODO SIMPLIFICADO DO {A:F2}

            char caracter = '*'; // caracter que será impresso
            int tamanho = texto.Length + 4; // tamanho da linha
            string linha = new string(caracter, tamanho); // linha com o caracter
            string textocentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // texto centralizado
            Console.WriteLine(linha); // imprime a linha 
            Console.WriteLine(textocentralizado); // imprime o texto centralizado 
            Console.WriteLine(linha);
        } 


    }
}
