internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            Console.Write("| ****************************************************************** |");
            Console.WriteLine();
            //Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

            //- Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
            //-Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
            //-Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
            //- Si el IMC es mayor de 29.9 entonces tiene obesidad.

            //Solicitando datos
            Console.WriteLine();
            Console.Write("Ingrese el nombre de un paciente: ");
            String? n = Convert.ToString(Console.ReadLine()); Console.WriteLine();
            double peso, altura;

            Console.Write("Ingrese el peso del paciente en kl: "); peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el altura del paciente en cm: "); altura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double IMC = (peso / Math.Pow(2,altura));
            Console.WriteLine();
            if (IMC < 18.5)
                Console.WriteLine($"El paciente {n} tiene peso insuficiente");
            else if (IMC >= 18.5 && IMC <= 24.9)
                Console.WriteLine($"El paciente {n} tiene peso saludable");
            else if (IMC >= 25.0 && IMC <= 29.9)
                Console.WriteLine($"El paciente {n} tiene sobrepeso");
            else   
                Console.WriteLine($"El paciente {n} tiene obesidad"); Console.WriteLine();
    
        
                Console.WriteLine("¿Desea calcular el IMC de otro paciente? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s")
            {
                break;
            }   
            }
            while (true) ;
    }
}     
