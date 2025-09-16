int num = 1000;
int divisor = 11;
while (num<= 2000)
{
    Console.WriteLine($"{num}");
    if (num % divisor == 5)
    {
        Console.WriteLine($"Então {num} dividido por {divisor} produzem resto 5");
    }
    num++;
}