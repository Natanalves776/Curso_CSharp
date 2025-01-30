namespace metodos_e_funçoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4,3]; // matriz n esquece cabeça de gelo 

            matriz[0, 0] = 10;    // colunas e lembre matriz te lembra planilha
            matriz[0, 1] = 15;
            matriz[0, 2] = 20;

            matriz[1, 0] = 25;
            matriz[1, 1] = 30;
            matriz[1, 2] = 35;

            matriz[2, 0] = 40;
            matriz[2, 1] = 45;
            matriz[2, 2] = 50;

            matriz[3, 0] = 55;
            matriz[3, 1] = 60;
            matriz[3, 2] = 65;

            for (int i = 0; i < 4; i++) // linhas 
            {
                for (int j = 0; j < 3; j++) //colunas
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(matriz.GetLength(0)); // quantidade de linhas
            Console.WriteLine(matriz.GetLength(1)); // quantidade de colunas 
        }
    }
}
