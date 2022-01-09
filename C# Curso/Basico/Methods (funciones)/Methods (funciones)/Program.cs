// See https://aka.ms/new-console-template for more information
Console.WriteLine("FUNCIONES \n");

float[] precios_array = { 1.8f, 2, 3, 4, 5.2f, 6.5f };


Random random = new Random();
Console.WriteLine("valor random");
Console.WriteLine($"N:{random.Next(1 , 20)}");

Console.WriteLine(precios_array[0]);



static double suma(double num1, double num2)
{

    //Console.WriteLine($"La suma de los numeros es: {num1 + num2}");

    return num1/num2;

}


static void mensajeEnPantalla() => Console.WriteLine("mensaje desde el metodo mensajeEnPantalla");

mensajeEnPantalla();

Console.WriteLine("Ingresa datos para sumar");
double uno=Convert.ToInt32(Console.ReadLine());
double dos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Resultado de la suma {suma(uno, dos)}");