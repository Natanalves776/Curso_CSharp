namespace calculador_de_area_de_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Cálcular a Área do triangulo");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Digite altura do triangulo:  ");
            double L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite lado direito do triangulo:  ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();




            area(L, C);


        }
        static void area(double largura, double comprimento)
        {
            double a = largura * comprimento / 2;
            Console.WriteLine($"A base e a altura do triangulo é {largura} x {comprimento} é de {a:F2}m²");
            
        }
    }
}
        