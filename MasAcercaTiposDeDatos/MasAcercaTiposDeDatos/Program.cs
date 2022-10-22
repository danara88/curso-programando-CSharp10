// toString()
// Transformar un tipo de dato a string
using MasAcercaTiposDeDatos;

int cantidadNumber = 5;
string cantidadString = cantidadNumber.ToString();

string myDate = DateTime.Today.ToString("yyyy-MM-dd");

// int.Parse(), decimal.Parse(), bool.Parse(), etc
// Parciar a numero
string miCantidad = "5";
int miCantidadNumber = int.Parse(miCantidad);

string fechaString = "2022-05-09";
DateTime fecha = DateTime.Parse(fechaString);

// Intentar parsear
// No parsear de manera directa. Si hay un error, retorna falso
// en lugar de retornar una excepsion.
string supuestoNumero = "5";
int numero;
// out: Le permito a la funcion TryParse modificar la variable "numero" desde
// dentro de la funcionalidad
var puedeParsear = int.TryParse(supuestoNumero, out numero);
if (puedeParsear)
{
    // Lugar seguro para usar la variable
    numero++;
    Console.WriteLine(numero);
}
else
{
    Console.WriteLine("La variable no tiene el formato correcto");
}

// Castep explicito
// Consiste en pasar de un tipo de dato a otro
// Tenemos que tener cuidado por los Overflow
// Ejemplo: Aveces un int no puede caber en una vairable tipo byte
var cantidad1 = 5;
var cantidad2 = 7;

var division = (double)cantidad1 / cantidad2; // Casteo explicito
Console.WriteLine(division);

// Casteo implicito
// Un byte siempre va a caber en un int

byte byte1 = 11; // 0 a 255
int int1 = byte1; // no marca error porque C# sabe que si cabe.

// ENUM
// Conjunto de constantes almacenadas
// Por detras, los valoes del enum son numeros
var estatusVentaCamisa = EstatusVenta.Cancelado;
switch (estatusVentaCamisa)
{
    case EstatusVenta.Exitoso:
        Console.WriteLine("Exitoso");
        break;
    case EstatusVenta.Pendiente:
        Console.WriteLine("Pendiente");
        break;
    case EstatusVenta.Cancelado:
        Console.WriteLine("Cancelado");
        break;
    default:
        Console.WriteLine("Desconocido");
        break;
}

int estatusVentaInt = (int)estatusVentaCamisa; // Numero
int estatus = 1;
EstatusVenta estatusNombre = (EstatusVenta)estatus;
Console.WriteLine(estatusNombre);

// ARREGLOS
char[] vocales = new char[5] { 'a','e','i','o','u' };
int[] ages = new int[4] { 24, 45, 60, 90 };

foreach (var vocal in vocales)
{
    Console.Write(vocal);
}

// Encontrar el numero mayor en el arreglo O(n)
int[] items = new int[6] { 20, 10, 15, 67, 24, 200 };
int selectedItem = items[0]; // 20
for (int i = 0; i < items.Length; i++)
{
    var nextIndex = i + 1;
    if (nextIndex <= items.Length - 1 && selectedItem < items[nextIndex])
    {
        selectedItem = items[nextIndex];
    }
}
Console.WriteLine($"El numero mayor es: {selectedItem}");

var ultimaVocal = vocales[^1]; // 5 utima vocal
Range dosPrimeros = ..2;
var dosPrimerasVocales = vocales[dosPrimeros]; // 0, 1
var dosUltimasVocales = vocales[^2..]; // ^2, ^1
var dosUltimasVocalesVersion2 = vocales[3..]; // 3, 4
var tresEnMedio = vocales[1..4]; // 1,2,3

// Arreglos multidimensionales
int[,] matriz = new int[2, 2]; // Dos filas y dos columnas de tipo int

matriz[0, 0] = 1; // Primera fila, primera columna
matriz[0, 1] = 2; // Primera fila, seguinda columna
matriz[1, 0] = 3; // Segunda fila, primera columna
matriz[1, 1] = 4; // Segunda fila, segunda columna

int[,] matrizV2 = new int[,] // 3 filas y dos columnas
{
    { 5, 6 }, // Primera fila
    { 7, -5 }, // Segunda fila
    { 8, 4 } // Tercera fila
};

for (int fila = 0; fila < matriz.GetLength(0); fila++)
{
    for (int columna = 0; columna < matriz.GetLength(1); columna++)
    {
        Console.Write($"{matriz[fila, columna]}");
    }
    Console.WriteLine();
}

// Arreglos de arreglos
int[][] arreglosDearreglos =
{
    new int[] {1, 2}, // Fila
    new int[] {3, 4, 5, 6}, // Fila
    new int[] {-7}   // Fila
};

var segundoElemento = arreglosDearreglos[1]; // {3,4}

for (int fila = 0; fila < arreglosDearreglos.Length; fila++)
{
    var arreglo = arreglosDearreglos[fila];
    for (int columna = 0; columna < arreglo.Length; columna++)
    {
        Console.Write($"{arreglo[columna]} ");
    }
    Console.WriteLine();
}

// Manipulacion de strings
var nombre = "Daniel";

var nombreMayusculas = nombre.ToUpper(); // Mayusculas

var nombreMinusculas = nombre.ToLower(); // Minusculas

// Uso del Trim()
var mensaje = "123Hola mundo345";
char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
var mensajeArreglado = mensaje.Trim(numeros);
Console.WriteLine(mensajeArreglado);

// Uso del PadLeft()
long monto1 = 123;
long monto2 = 4;
long monto3 = 122121212;
long monto4 = 1232232323L;

Console.WriteLine(monto1.ToString().PadLeft(10, '0'));
Console.WriteLine(monto2.ToString().PadLeft(10, '0'));
Console.WriteLine(monto3.ToString().PadLeft(10, '0'));
Console.WriteLine(monto4.ToString().PadLeft(10, '0'));


