Console.WriteLine("Digite um valor que não seja 0");
double num1 = double.Parse(Console.ReadLine());
if (num1 < 0)
{
    Console.WriteLine("Esse número é negativo!");
}
else
{
    Console.WriteLine("Esse número é positivo!");
}
