// Logica booleana
var cantidad1 = 2;
var cantidad2 = 3;
var resultado = cantidad1 == cantidad2;

var nombre = "Daniel";
var isNulo = nombre is null; // Buena practica en vez de utilizar ==
var noEsNulo = nombre is not null;

// Sentencia Swicth
var year = 2022;
switch(year)
{
    case 2021:
        Console.WriteLine(2021);
        break;
    case 2022:
        Console.WriteLine(2022);
        break;
}

// Switch corto
var lugar = 0;
var message = lugar switch
{
    0 => "miami",
    1 => "los angeles",
    2 or 3 => "monterrey",
    _ => "otro"
};



// Patrones relacionales
var temp = 37;
var mensaje = temp switch
{
    37 => "No hay condicional",
    > 37 and < 39 => "Tienes temperatura",
    >= 39 => "Temperatura muy alta",
    < 37 => "Tienes una condicion"
};
Console.WriteLine(mensaje);

var date = DateTime.Now;
var estacion = date.Month switch
{
    1 or 2 or 3 => "Primavera",
    4 or 5 or 6 => "Verano",
    7 or 8 or 9 => "Otono",
    10 or 11 or 12 => "Invierno",
    _ => throw new ApplicationException("Mes no especificado")
};

Console.WriteLine("Aqui /////");
var n = 15;
for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
        continue;
    }
    if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
        continue;
    }
    if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
        continue;
    }
    Console.WriteLine(i);
}