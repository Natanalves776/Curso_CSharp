namespace votação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasc; 
            Console.WriteLine("digite seu ano de nascimento?   ");
            nasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(voto(nasc));

        }

        static string voto( int ano)
        {
            DateTime dataAtual = DateTime.Now;
           // int dia = dataAtual.Day;
           // int mes = dataAtual.Month;
            int  anoAtual = dataAtual.Year;
            int  idade = anoAtual - ano;

            if (idade < 16)
            {
                return $"com {idade} anos, vocé não pode votar";
            }
            else if (idade > 18 && idade < 70)
            {
              return $" {idade} anos, você vota";
            }
            else
            {
                return $"com {idade} anos, seu voto é opcional";
            }
            // int hora = dataAtual.Hour;
            // int minuto = dataAtual.Minute;
            // int segundo = dataAtual.Second;
        }
    }
}
