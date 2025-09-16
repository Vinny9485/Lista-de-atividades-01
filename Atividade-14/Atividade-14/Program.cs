Console.WriteLine("Digite um número que não seja 0");
int num;
num = int.Parse(Console.ReadLine());
for (int i = 1; i < num; i++)
{
    Console.WriteLine($"{num - i}");
}