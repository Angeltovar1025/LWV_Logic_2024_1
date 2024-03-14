internal class Program
{
    private static void Main(string[] args)
    {
        //Construir un algoritmo que pida N numeros por pantalla, Cuando el usuairo ingrese un numero negativo.
        //el programa debe finalizar y mostrar en consola la cantidad total de numeros
        //positivos que ingreso hasta antes de ingresarse el numero negativo.

        // Variables de entrada
        int num, contador = 0;
        bool validador = true;

        //FORMA 1
        //Creación del Cicl
        while (validador) //Flag
        {
            Console.Write("Ingrese un número: "); num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
                validador = false;
            else
                contador = contador + 1;
        }


        //FORMA 2
        // 1. Omito la creación de la variable o estado Flag (la variable validador)
        // 2. True, sino va con la palabra reservada "break", sino se genera un bucle infinito

        //Creación del Cicl
        while (true) //Flag//
        {
            Console.Write("Ingrese un número: "); num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
                break; //Quiébreme el while para que no vuelva a entrar
            else
                contador = contador + 1;
        }
        Console.WriteLine(string.Format("El total de números positivos ingresados es de {0}", contador));

    }
}