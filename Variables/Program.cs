// See https://aka.ms/new-console-template for more information

// Sentencias de alto nivel: (Top-Level Statements)
// A partir de C# 9 fueron hechas las sentencias de alto nivel para evitar escribir
// mucho codigo. En vez de escribir los namespace, la clase Program y demas codigo...
// Detras de camara este codigo de sentencia de alto nivel es convertido en un
// codigo especial que indica el punto de entrada de tu aplicacion.
// (Solo puede haber un punto de entrada)
//
// Un programa solo puede tener un archivo con sentencias de alto nivel ya que
// el programa solo admite un punto de entrada.

Console.WriteLine("Hello, World!"); // Sentencia, esta termina con punto y coma

int earthSunDistance = 150_000_000;
Console.WriteLine(earthSunDistance);


//  NUMEROS FLOTANTES
//
// Entre mayor espacio ocupa, mas precision tienen

float altura = 175.5f; // De 6 a 9 digitos

double anchura = 45.99; // De 15 a 17 digitos

decimal tasaInteres = 9.99m; // De 28 a 29 digitos Recomendado para temas de dinero

Console.WriteLine(altura);
Console.WriteLine(anchura);
Console.WriteLine(tasaInteres);

string myCompleteName = "Daniel Aranda \" ";

Console.WriteLine(myCompleteName);


// STRINGS VERBATIM
//
// Nos permite tener varias lineas de texto y
// ahorrarnos la secuencia de escape del backslash
//
string carta = @"A quien pueda interesar, 
    Es timado cliente, deber mucho dinero.
    Att: La administracion
";

string myPath = @"c:\www\wamp64\www";
Console.WriteLine(myPath);


// DateTime

DateTime ahora = DateTime.Now;

DateTime birthday = new DateTime(2022, 1, 10, 10, 00, 00);

DateTime tomorrow = DateTime.Now.AddDays(1);


// VALORES POR DEFECTO
int edad = default; // Estoy asignando el valor por default para un int
Console.WriteLine(edad);
edad = 3;

string myOtherName = null; // No hay referencia alguna a un valor en el heap


// OPERACIONES UNARIAS
var cantidad1 = 7;
var cantidad2 = 5;

// Primero se suma 1 a cantidad1 y luego se evalua toda la expresion
var suma = ++cantidad1 + cantidad2; // 8 + 5
// cantidad1 = cantidad1 + 1; (cantidad1 + cantdiad2); 
Console.WriteLine(suma);

// Primero se evalua toda la expresion y luego se le suma 1 a cantidad1
var suma2 = cantidad1++ + cantidad2; // 7 + 5
// (cantidad1 + cantdiad2); cantidad1 = cantidad1 + 1;
Console.WriteLine(suma2);

// CONSTANTES

const int miEdad = 21;