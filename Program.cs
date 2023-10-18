// See https://aka.ms/new-console-template for more information

// Comprobación de un número.
var num1 = 128;
var num2 = 64;

Console.WriteLine("Por favor, sea tan amable e ingrese la suma de: " + num1 + " y " + num2 + ": ");

var respuesta  = Console.ReadLine();
var resultado  = Convert.ToInt32(respuesta);
var esCorrecto = resultado == (num1 + num2); Console.WriteLine("Tu respuesta es: " + esCorrecto);

for (int i = 0; i < 4; i++) {
    Console.WriteLine("-------");
}

// Doble de un número
var num = 128;

Console.WriteLine("Si es tan amable, ingrese el doble del siguiente número: " + num + " : ");

respuesta = Console.ReadLine();

resultado = Convert.ToInt32(respuesta);

esCorrecto = resultado == (num * 2);

Console.WriteLine("Tu respuesta es: " + esCorrecto);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("-------");
}

// Verificación de un número...
num = 64;

Console.WriteLine("Si es tan amable, ingrese el número: " + num + ": ");

respuesta = Console.ReadLine();

var numIngresado = Convert.ToInt32(respuesta);

esCorrecto = numIngresado == num;

Console.WriteLine("Tu respuesta es: " + esCorrecto);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("-------");
}

// Incremento y Decremento.
num = 40;

Console.WriteLine("El valor inicial es: " + num);
num++;

Console.WriteLine("Después de aumentar, el valor es: " + num);
num--;

Console.WriteLine("Después de disminuir, el valor es: " + num);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("-------");
}

// Usando otra constante.
const double PI = 3.14159265359;

double radio = 45.0; 
double area  = PI * radio * radio;

Console.WriteLine("El valor de PI es una constante: " + PI);
Console.WriteLine("Dado un radio de: " + radio + " unidades,");
Console.WriteLine("El área de un círculo es: " + area + " unidades cuadradas.");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("-------");
}