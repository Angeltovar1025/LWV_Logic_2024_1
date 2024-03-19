internal class Program
{
    private static void Main(string[] args)
    {
        //Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese un número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo

        //Declaración de variables
        int option;
        double suma, resta, producto, cociente, num1, num2;
        //Flag para volver o salir del programa
        bool exit = false;
        
        do
        {
            Console.Write("Ingrese los dos números: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();

            Console.Write("---------------MENÚ OPERACIONES ARTIMÉTICAS-----------------");
            Console.Write("- Seleccione una una operación atirmética para sus números: ");
            Console.Write("------------------------------------------------------------");
            Console.Write("")
        }
        while (!exit)


        //
        //Console.WriteLine("Hello, World!");
    }
}