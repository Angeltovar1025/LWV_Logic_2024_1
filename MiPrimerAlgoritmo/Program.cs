using System;

internal class Program
{
    public static void Main(string[] args)
    {

        // Se declaran las variables
        double Num1, Num2, Num3;
        double suma, rest, prod, coc, Exp1, Exp2;


        //Lea el Num1
        Console.Write("Ingrese el primer número: ");
        Num1 = Convert.ToInt32 (Console.ReadLine ()); //Todo lo que se ingrese será tomado como String
        Console.WriteLine( );

        //Lea el Num2
        Console.Write("Ingrese el segundo número, este número debe ser diferente de 0: ");
        Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( );

        //Lea el Exponente
        Console.Write("Ingrese el número exponente, este número debe ser diferente de 0: ");
        Num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //se calculan las operaciones

       suma = Num1 + Num2;
       rest = Num1 - Num2;
       prod = Num1 * Num2;
       coc = Num1 / Num2;
       Exp1 = Math.Pow (Num1 , Num3);
       Exp2 = Math.Pow (Num2, Num3);

        //Presentar en Pantalla
        Console.WriteLine("Suma...........: " + Num1 +  " + " +  Num2 + " = " + suma);
        Console.WriteLine("Resta..........: " + Num1 +  " - " +  Num2 + " = " + rest);
        Console.WriteLine("Multiplicación.: " + Num1 + " * " + Num2 + " = " + prod);
        Console.WriteLine("División.......: " + Num1 + " / " + Num2 + " = " + coc);
        Console.WriteLine("Potencia1.......: " + Num1 + " elevado al número " + Num3 + " = " + Exp1);
        Console.WriteLine("Potencia2.......: " + Num2 + " elevado al número " + Num3 + " = " + Exp2);






    }
}