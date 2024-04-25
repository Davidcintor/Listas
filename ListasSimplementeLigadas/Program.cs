using ListasSimplementeLigadas;


Lista miLista = new Lista();
miLista.Agregar("cero");
miLista.Agregar("uno");
miLista.Agregar("dos");
miLista.Agregar("tres");
miLista.Agregar("cuatro");

string elementos = miLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
Nodo encontrado = miLista.Buscar("dos");
Console.WriteLine(encontrado.Valor);

Console.WriteLine();
Nodo encontrado2 = miLista.BuscarNodoAnterior("dos");
Console.WriteLine(encontrado2.Valor);

Console.WriteLine();
miLista.Borrar("dos");
elementos = miLista.Recorrer();
Console.WriteLine(elementos);
