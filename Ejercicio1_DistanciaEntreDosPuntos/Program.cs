internal class Program

{
    public static void Main(string[] args)
    {
        //Lea las coordenadas  de dos puntos y muestre la distancia los dos puntos.

        //Datos de entrada: Son 4 variables
        //Declaración de variable

        Double X1, X2, Y1, Y2, Distancia;

        //Solicitud de datos de entrada
        Console.Write("Por favor digita el dato X1: ");
        X1 = double.Parse(Console.ReadLine());

        Console.Write("Por favor digita el dato Y1: ");
        Y1 = double.Parse(Console.ReadLine());

        Console.Write("Por favor digita el dato X2: ");
        X2 = double.Parse(Console.ReadLine());

        Console.Write("Por favor digita el dato Y2: ");
        Y2 = double.Parse(Console.ReadLine()); Console.WriteLine();



        //Calculo
        Distancia = Math.Sqrt((Math.Pow(X2 - X1, 2)) + ((Math.Pow(X2 - X1, 2))));

        //Presentar por pantalla
        Console.WriteLine(String.Format("La distancia entre dos puntos " +
            "({0},{1}) y ({2},{3}) es = {4}", X1, Y1, X2, Y2, Distancia
            .ToString("N1")));



    }
}