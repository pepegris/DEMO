// See https://aka.ms/new-console-template for more information
Console.WriteLine("clicos");



Console.WriteLine("ingresa un numero 1-2-3");

int switch1 = Convert.ToInt32(Console.ReadLine());

switch (switch1)
{
    case 1:
        Console.WriteLine("estado 1");
        break;
    case 2:
        Console.WriteLine("estado 2");
        break;
    case 3:
        Console.WriteLine("estado 3");
        break;
    default:
        Console.WriteLine("no ingresaste un numero validoo ");
        break;
}


for (int i = 1; i <= 10; i++)
    Console.WriteLine(i);

int numero=Convert.ToInt32(Console.ReadLine());

while ( numero != 10)
{

    
    Console.WriteLine($"bucle contando numero ingresado {numero}");
    numero++;

}
