Console.WriteLine("Quantos anos você tem?");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos meses se passaram do seu aniversário?");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos dias se passaram do seu aniversário?");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine($"Então a sua idade em dias é {(idade*365)+(mes*30)+dia}");
