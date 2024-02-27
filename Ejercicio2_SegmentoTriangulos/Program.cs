internal class Program

{
    public static void Main(string[] args)
    {
        //Lea la longitud de tres segmentos y que muestre si se
        //puede construir un triángulo con estos segmentos.

        //Datos de entrada: Son 3 Segmentos
        //Declaración de variable

        Double Seg1, Seg2, Seg3;
        String mensaje = "se puede contruir un Triangulo";

        //Solicitud de datos de entrada
        Console.Write("SEGMENTO POSITIVO \n");
        Console.Write("\nPor favor digita el Primer Segmento: ");
        Seg1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nPor favor digita el Segundo Segmento: ");
        Seg2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nPor favor digita el Tercer Segmento: ");
        Seg3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //Validar
        if (((Seg1 + Seg2) > Seg3) && ((Seg1 + Seg3) > Seg2) && ((Seg2 + Seg3) > Seg1))
            Console.Write(String.Format("Si {0}", mensaje));
        else
            Console.Write(String.Format("No {0}", mensaje));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

    }
}