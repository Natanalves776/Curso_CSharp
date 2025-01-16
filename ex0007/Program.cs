using System.ComponentModel.Design;

namespace ex0007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final;
            string resultado;

            Console.Write(" digite a nota final do aluno");
            nota_final = Convert.ToDouble(Console.ReadLine());

            if (nota_final >= 70)
            {
                resultado = "aprovado";


                if (nota_final >= 95)
                {
                    resultado = "aprovado com louvor ";
                }
                
                
                
            }

            else if (nota_final >= 45)
            {
                resultado = "recuperação";
            }    
            else 
            
            
            {
                resultado = "Reprovado";

            }
            
            
            Console.WriteLine("nota do aluno: {0} -  resultado: {1}",nota_final, resultado);

           
        }


    }
}
