Console.WriteLine("Quantos reais você tem?");
double reais = double.Parse(Console.ReadLine());
double dolar = (reais/3.45);
Console.WriteLine($"Então você tem US${dolar}");