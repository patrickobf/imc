using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        { 

        
         

            Console.Write("Hello World!");
            Console.ReadKey();

            Console.WriteLine("Qual o seu nome?");
            Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            Console.ReadLine();

            

            Console.WriteLine("Qual o seu peso?");
            var P = float.Parse(Console.ReadLine());


            Console.WriteLine("Qual a sua altura?");
            var A = float.Parse(Console.ReadLine());

            var imc = (P / (A * A));

            if (imc <= 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }


            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal");
            }


            else if ((imc > 25) && (imc < 30))
            {
                Console.WriteLine("Acima do Peso");
            }


            if (imc > 30)
            {
                Console.WriteLine("Grau de Obesidade");

            }

            Console.ReadKey();


        }

    }

} 
    
 
