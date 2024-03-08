internal class Program
{
    public static void Main(string[] args)
    {        //***1.	Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos
        double x1, x2, y1, y2, distancia;
        //Entrada
        Console.Write("Digite el punto x1: ");x1 = double.Parse(Console.ReadLine()); Console.WriteLine();
        Console.Write("Digite el punto x2: "); x2 = double.Parse(Console.ReadLine()); Console.WriteLine();
        Console.Write("Digite el punto y1: "); y1 = double.Parse(Console.ReadLine()); Console.WriteLine();
        Console.Write("Digite el punto y2: "); y2 = double.Parse(Console.ReadLine()); Console.WriteLine();
        distancia = Math.Sqrt((Math.Pow(x2 - x1,2)) + ((Math.Pow(y2 - y1,2))));
        //presentar por pantalla
        Console.WriteLine("La distancia entre dos puntos es de " + distancia.ToString("N1"));
    }
}