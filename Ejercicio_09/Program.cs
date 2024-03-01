internal class Program
{
    public static void Main(string[] args)
    {
       
        // se declaran variables
        Double Num1, Num2, Num3;

        //datos de entrada
        Console.Write("Digite el primer numero: ");
        Num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        Num2 = Convert.ToInt32(Console.ReadLine());
    

        Console.Write("Digite el tercer numero: ");
        Num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if ((Num1 > Num2) && (Num1 > Num3))

            Console.WriteLine("El Numero mayor es: " + Num1);
        else
            if ((Num2 > Num3 ))
            Console.WriteLine("El Numero mayor es: " + Num2);
        else
            Console.WriteLine("El Numero mayor es: " + Num3);
    }
}