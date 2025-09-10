Console.WriteLine("Nesse programa vacê irá digitar dois números DIFERENTES");
Console.WriteLine("Então digite o primeiro número:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o segundo número:");
double num2 = double.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"O número {num1} é maior que o número {num2}");
}
else
{
    Console.WriteLine($"O número {num2} é maior que o número {num1}");
}