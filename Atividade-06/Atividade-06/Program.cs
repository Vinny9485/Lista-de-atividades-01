Console.WriteLine("Qual é o seu salário?");
float salario = float.Parse(Console.ReadLine());
Console.WriteLine("Quanto será o reajuste salarial?");
float reajuste = float.Parse(Console.ReadLine());
Console.WriteLine($"Então o reajuste será de {100+reajuste}% e o novo salário será de R${((reajuste/100)*salario)+salario}");
