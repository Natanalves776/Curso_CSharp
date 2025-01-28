namespace vetor_fruta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "maça", "melão", "morango", "abacaxi", "uva", "lichia", "jaca", "mamão", "maracuja", "abacate" };
            double[] preço = { 10.5, 10.4, 9.4, 5.6, 66.5, 56.2, 54.5, 7.80, 8.3, 88.6 , };

            for (int i = 0; i < frutas.Length; i++)

            {
                if (i < frutas.Length - 1)
                { Console.Write(frutas[i] + ", "); }
                else
                {
                    Console.WriteLine(frutas[10] + ".");
                }

                Console.WriteLine(preço[i]);
                Console.WriteLine();
                               


            }
        }
    }

}
