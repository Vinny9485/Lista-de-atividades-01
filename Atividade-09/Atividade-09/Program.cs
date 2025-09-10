Console.WriteLine("Quantas maçãs você quer comprar?");
int quantidade = int.Parse(Console.ReadLine());
if (quantidade < 12)
{
    Console.WriteLine($"Então o valor da sua compra será de R${quantidade * 1.30}");
}
else
{
    Console.WriteLine($"Então o valor da sua compra será de R${quantidade * 1.00}");
}