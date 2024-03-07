using System.Timers;

internal class Program
{
    public static void Main(string[] args)
    {
        //******Creado por Ángel Tovar********
        //Pizzería Bella Napoli: Ofrece pizzas vegetarianas y no vegetariana

        //Datos de entrada
        Console.WriteLine("******Creado por Ángel Tovar******"); Console.WriteLine();
        Console.Write("Bienvenido a Pizzería Bella Napoli, le ofrecemos menú Vegetariano y no Vegetariano"); Console.WriteLine();
        Console.Write("¿Desea pizza vegetariana? Si/no: ");
        String? respuesta = Console.ReadLine(); Console.WriteLine();
               
        if (respuesta == "si")
        {
            MenuVegetariano();
        }
        else if (respuesta == "no")
        {
            MenuNoVegetariano();
        }
        else
        {
            Console.Write("Respuesta no válida. Seleccione Si o No"); Console.WriteLine();      
        }
        static void MenuVegetariano()
        {
            String tipoPizza = "Vegetariana";
            Console.WriteLine("Ingredientes disponibles para la pizza vegetariana: ");
            Console.WriteLine("1. Pimiento");
            Console.WriteLine("2. Tofu");
            Console.WriteLine("Elige un ingrediente (escribe el número):");
            string eleccion = Console.ReadLine();

            if (eleccion == "1")
                Console.WriteLine($"Has elegido una pizza {tipoPizza} con mozarella y pimiento.");
            else if (eleccion == "2")
                Console.WriteLine($"Has elegido una pizza{tipoPizza} con mozarella, tomate y tofu.");
            else Console.WriteLine("Elección no válida. Selecciona 1 o 2");
        }
        static void MenuNoVegetariano()
        {
            String tipoPizza = "No Vegetariana";
            Console.WriteLine("Ingredientes disponibles para la pizza no vegetariana: ");
            Console.WriteLine("1. Peperoni");
            Console.WriteLine("2. Jamón");
            Console.WriteLine("3. Salmón");
            Console.WriteLine();
            Console.WriteLine("Elige un ingrediente (escribe el número):");
            String eleccion = Console.ReadLine();
            Console.WriteLine();

            if (eleccion == "1")
                Console.WriteLine($"Has elegido una pizza {tipoPizza} con mozzarella, tomate y Peperoni.");
            else if (eleccion == "2")
                Console.WriteLine($"Has elegido una pizza {tipoPizza} con mozzarella, tomate y Jamón.");
            else if (eleccion == "3")
                Console.WriteLine($"Has elegido una pizza {tipoPizza} con mozzarella, tomate y Salmón.");
            else
                Console.WriteLine("Opción no válida. Selecciona 1, 2 o 3.");
        }
    }
}
