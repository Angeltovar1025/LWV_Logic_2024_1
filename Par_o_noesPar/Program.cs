internal class Program
{
    public static void Main(string[] args)
    {

        //Se declaran variables
        int Num;

        //Se llama el Numero
        Console.Write("Ingrese un Numero: ");
        Num = int.Parse(Console.ReadLine());

        Console.WriteLine();

        //Se valida si es par o no
        if (Num % 2 == 0)
        {
            Console.WriteLine("Es un numero Par");
        }
        else
        {
            Console.WriteLine("Es un numero Impar");
        }
        Console.WriteLine();
    }
}