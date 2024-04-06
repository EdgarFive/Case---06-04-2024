



using Case___06_04_2024.Claces;

Carro cccarrito = new Carro("Toyota", 2024, "Blanco");
Carro cccarrito2 = new Carro("Nissan",2020,"Azul");

cccarrito.Encender();


if (cccarrito.Acelerar() == 0)
{
    Console.WriteLine($"El carro está apagado");
} else
{
    Console.WriteLine(cccarrito.Acelerar() + " km/h");
    Console.WriteLine(cccarrito.Acelerar() + " km/h");
    Console.WriteLine(cccarrito.Acelerar() + " km/h");
}

cccarrito.Encender();
Console.WriteLine(cccarrito.Acelerar() + " km/h");























/*
//cccarrito.Marca = "Toyota";
//cccarrito.Modelo = 2021;
cccarrito.Color = "Rojo";
cccarrito.owner = "Juan";
cccarrito.MAXVELOCIDAD = 200;

Console.WriteLine($"El carro es un {cccarrito.Marca}");

Console.WriteLine($"Mi segundo carro es un {cccarrito2.Marca}");

Console.ReadKey();


//cccarrito.Marca = "Nissan";
//Console.WriteLine($"El carro es un {cccarrito.Marca}");
//Console.ReadKey();
*/