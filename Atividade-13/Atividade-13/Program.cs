Console.WriteLine("Nesse programa você irá digitar três números DIFERENTES");
Console.WriteLine("Então digite o primeiro número:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o segundo número:");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o terceiro número:");
double num3 =  double.Parse(Console.ReadLine());
if (num1 > num2 && num1 > num3 && num2 > num3)
{
    Console.WriteLine($"Então em ordem crescente os números ficam assim: {num3}, {num2} e {num1}");
}
else if (num1 > num2 && num1 > num3 && num2 < num3)
{
    Console.WriteLine($"Então em ordem crescente os números ficam assim: {num2}, {num3} e {num1}");
}
else if (num1 < num2 && num1 < num3 && num2 < num3 )
{
    Console.WriteLine($"Então em ordem crescente os número ficam assim: {num1}, {num2} e {num3}");
}
else if (num1 < num2 && num1 < num3 && num2 > num3)
{
    Console.WriteLine($"Então em ordem crescente os número ficam assim: {num1}, {num3} e {num2}");
}
else if (num2 > num1 && num2 > num3 && num1 > num3)
{
    Console.WriteLine($"Então em ordem crescente os números ficam assim: {num3}, {num1} e {num2}");
}
else 
{
    Console.WriteLine($"Então em ordem crescente os número ficam assim: {num2}, {num1} e {num3}");
}