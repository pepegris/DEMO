// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arreglos \n \n Ingresa la Tasa del dia");

float tasa= Convert.ToSingle(Console.ReadLine());
string[] tipos_cafe;
float[] precios_cafe;

tipos_cafe= new string[] {"Cafe con leche" , "Cafe Negro" , "Sin Azucar"};
precios_cafe = new float[] { 10, 7, 5.5f };

for (int i = 0; i < tipos_cafe.Length; i++)
    Console.WriteLine($"{tipos_cafe[i]} - {precios_cafe[i]}$ / {precios_cafe[i]*tasa}BS");
