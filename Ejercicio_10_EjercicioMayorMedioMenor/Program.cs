using System;
using System.ComponentModel.Design;
using System.Timers;

internal class Program
{
    public static void Main(string[] args)
    {
        //10.	Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados
        //Se declaran variables 

        Double n1, n2, n3;

        //Datos de entreada
        Console.WriteLine("****Algoritmo creado por Angel Tovar***");
        Console.WriteLine();
        Console.Write("Ingrese el primer numero ");   n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Ingrese el sgundo numero ");   n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Ingrese el tercer numero ");   n3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        
        //validacion
        if ((n1 > n2) && (n2 > n3))
        { 
                Console.WriteLine("El numero mayor es " + n1);
                Console.WriteLine("El numero medio es " + n2);
                Console.WriteLine("El numero menor es " + n3);
        }
        else  if ((n2 > n1) && (n1 >n3))
        { 
                Console.WriteLine("El numero mayor es " + n2);
                Console.WriteLine("El numero medio es " + n1);
                Console.WriteLine("El numero menor es " + n3);
        }
        else if ((n3 > n2) && (n2 > n1))
        {
            Console.WriteLine("El numero mayor es " + n3);
            Console.WriteLine("El numero medio es " + n2);
            Console.WriteLine("El numero menor es " + n1);
        }
        else if ((n3 > n1) && (n1 > n2))
        {
            Console.WriteLine("El numero mayor es " + n3);
            Console.WriteLine("El numero medio es " + n1);
            Console.WriteLine("El numero menor es " + n2);
        }
        else
        {
            Console.WriteLine("Hay numeros iguales");
        }

    }
          
}