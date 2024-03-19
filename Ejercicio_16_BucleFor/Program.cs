internal class Program
{
    private static void Main(string[] args)
    {

        //Elabora un algoritmo que imprima los números del 1 al 100. Que calcule la suma de todos los números pares por un lado, y por otro, la de todos los impares.

        //Declaración de variables
        int acumuladorPar= 0, acumuladorImpar=0;

        for (int i = 1; i <=100; i++)
        {
            Console.WriteLine(i);

            //Identificar para acumular par o impar
            if (i % 2 == 0) acumuladorPar = acumuladorPar + 1;
            else acumuladorImpar = acumuladorPar += 1;
        }
        Console.WriteLine($"La suma de los pares es {acumuladorPar}" );
        Console.WriteLine($"La suma de los pares es {acumuladorImpar}" );
    }
}