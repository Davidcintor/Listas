using ListasDoblementeLigadas;

Lista miLista = new Lista();
miLista.Agregar("cero");
miLista.Agregar("uno");
miLista.Agregar("dos");
miLista.Agregar("tres");
miLista.Agregar("cuatro");

string elementos = miLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
Nodos encontrado = miLista.Buscar("dos");
Console.WriteLine(encontrado.Valor);

Console.WriteLine();
Nodos encontrado2 = miLista.Buscar("tres");
Console.WriteLine(encontrado2.Valor);

Console.WriteLine();
miLista.Borrar("dos");
elementos = miLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
miLista.Borrar("tres");
elementos = miLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
miLista.Borrar("uno");
elementos = miLista.Recorrer();
Console.WriteLine(elementos);


