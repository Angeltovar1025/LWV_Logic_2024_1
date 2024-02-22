
//using System;

using System;

public class Program
{
    public static void Main(string[] args)
    {

        // Se declaran las variables
        double Num1, Num2, Num3;
        double cuadrado, Rcuadrada, RCubica;



        //Lea el Num1
        Console.Write("Ingrese el primer número: ");
        Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //Lea el Num2
        Console.Write("Ingrese el segundo número, este número debe ser diferente de 0: ");
        Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //Lea el Num3
        Console.Write("Ingrese el número exponente, este número debe ser diferente de 0: ");
        Num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //se calculan las operaciones

        cuadrado = Num1 * Num1;
        Rcuadrada = Math.Sqrt (Num2);
        RCubica = Math.Cbrt (Num3);




        //Presentar en Pantalla
        Console.WriteLine("El Cuadrado de      " + Num1 + " es igual a " + cuadrado );
        Console.WriteLine("La Raíz Cuadrada de " + Num2 + " es igual a " + Rcuadrada);
        Console.WriteLine("La Raíz Cúbica de   " + Num3 + " es igual a " + RCubica);
    }
}