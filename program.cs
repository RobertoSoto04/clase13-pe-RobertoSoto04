using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Caso simple for
            for (int i=0;i< 10; i++)
            {

                console.WriteLine($"El numero {i}");
            }

            //fin for

            Console.WriteLine("\nIngrese un numero para elaborar su tabla de multiplicar")
            int numero=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10 ; i++)
            {
                int multiplicacion = numero * i;

                Console.WriteLine($"{numero} x {i} = {multiplicacion}")
            }

            //Foreach

             list<int> numeros = new list<int> {24,10,8,35,14,26};

             int minimo= numeros[0];

             foreach (int nummero in numeros)
             {
                if(numero < minimo)
                {
                    minimo = numero;
                }
             }

             Console.WriteLine("El numero mas pequeño en la lista es > " + minimo);


             console.ReadKey();
             //FIN
        }
    }
}