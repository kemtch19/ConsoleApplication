/* using System.Net.WebSockets;

int num1=3;
int num2=4;

int sum = num1 + num2;
Console.WriteLine(sum); */

/* Otra forma */
Console.Write("Ingresa el número uno: ");
string num1 = Console.ReadLine();

int num1Parseado;
int.TryParse(num1, out num1Parseado);

Console.Write("Ingresa el número dos: ");
string num2 = Console.ReadLine();

int num2Parseado;
int.TryParse(num2, out num2Parseado);

int sum = num1Parseado+num2Parseado;

Console.WriteLine($"La suma de {num1Parseado} y {num2Parseado} es {sum}");