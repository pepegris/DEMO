
using System;
using System.Globalization;

Console.WriteLine("Variables");

Console.WriteLine("Quieres acceder S/N");

string input = Console.ReadLine();


double height = 1.70;
int age = 28;
string name = "Andres salcedo";
string description = "ni noombre es " + name + " tengo " + age + " y mido " + height+" metros";

if (input.ToLower() == "s")
    Console.WriteLine( "Respuesta " +input+
        "\n"+description);
else
    Console.WriteLine("Respuesta " + input + "hasta luego");


Console.WriteLine("prueba codigo de internet");

string[] values = { "a tale of two cities", "gROWL to the rescue",
                          "inside the US government", "sports and MLB baseball",
                          "The Return of Sherlock Holmes", "UNICEF and children"};

TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
foreach (var value in values)
    Console.WriteLine("{0} --> {1}", value, ti.ToTitleCase(value));