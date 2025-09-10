Console.WriteLine("FAVOR DIGITAR TODOS OS VALORES EM METROS");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Qual é a altura da parede?");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Qual é o comprimento da parede?");
double comprimento = double.Parse(Console.ReadLine());
double area = altura * comprimento;
Console.WriteLine($"Então a área da parede é de {area}m² e irá precisar de {area * 2} litros de tinta.");