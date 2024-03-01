using System;

internal class Program
{
    public static void Main(string[] args)
    {

        //Se declaran variables
        Double Num1, Num2, Num3;

        //
         Console.Write("Digite el primer numero: ");
        Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Digite el segundo numero: ");
        Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Digite el tercer numero: ");
        Num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        //Validacion
        if ((Num1 > Num2) && (Num1 > Num3))

            Console.WriteLine("El numero mayor es: " + Num1);

        else 
            if ((Num2 > Num3))

        Console.WriteLine("El numero mayor es: " + Num2);
        else 
            Console.WriteLine("El numero mayor es: " + Num3);

    }
}