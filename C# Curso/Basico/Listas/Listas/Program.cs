Console.WriteLine("lista \n");

List<string> tienda_arepa = new List<string>();

tienda_arepa.Add("Reina pepiada");
tienda_arepa.Add("Catira");
tienda_arepa.Add("Chorizo");
tienda_arepa.Add("Dos Coca Colas");

/*
for (int i = 0; i < tienda_arepa.Count; i++) 
{ 
    Console.WriteLine(tienda_arepa[i]);
}
*/
tienda_arepa.Remove("Reina pepiada");
tienda_arepa.RemoveAt(2);

tienda_arepa.ForEach(t => Console.WriteLine(t));
