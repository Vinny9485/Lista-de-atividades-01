Console.WriteLine("Digite uma número que não seja negativo");
int num = int.Parse(Console.ReadLine());
if (num > 0)
{
    int i = 1;
    int fat = 1;
    while (i <= num)
    {
        fat = fat * i;
        i++;
    }
    Console.WriteLine($"Fatorial de {num} é igual a: {fat}");
}
else if (num == 0)
{
    Console.WriteLine($"{num}! = 1");
}
else
{
    Console.WriteLine("Fatorial negativo não existe!");
}