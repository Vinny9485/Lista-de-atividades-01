Console.WriteLine("Qual é o seu salário?");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine($"Então o seu novo salário com 15% de aumento é de R${salario * 1.15}");