//    Cree un programa que solicite al usuario el lado de un cuadrado. 
//    Luego le debe pedir una opción al usuario, si elige 1, le debe mostrar el perímetro del cuadrado, 
//    si elige 2, le debe mostrar el área del cuadrado.

//Datos de entrada
double opcion;
Console.Write("Elegir una opción 1 o 2: ");
opcion = Convert.ToDouble(Console.ReadLine()); Console.WriteLine();

Console.Write("Ingrese la distancia de uno de los lados: ");
double Lado = Convert.ToDouble(Console.ReadLine());
if (opcion == 1)
{
    double valor = calculararea(Lado);
    Console.WriteLine($"El area del cuadrado es de {valor.ToString("##,#0")}"); Console.WriteLine();
}
else
{
    double valor = calcularperimetro(Lado);
    Console.WriteLine($"El perímetro del cuadrado es de {valor.ToString("##,#0")}"); Console.WriteLine();
}
static double calcularperimetro(double Lado)
{
    double perimetro = (Lado * 4);
    return perimetro;
}
static double calculararea(double Lado)
{
    double area = (Lado * 2);
    return area;
}