Console.WriteLine("Quantos eleitores esse Município tem?");
int eleitores = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos votos foram válidos?");
float votosvalidos = float.Parse(Console.ReadLine());
Console.WriteLine("Quantos votos foram brancos?");
float votobranco = float.Parse(Console.ReadLine());
Console.WriteLine("Quantos votos foran nulos?");
float votonulo = float.Parse(Console.ReadLine());
Console.WriteLine($"Então nesse município tem {eleitores} eleitores e {(votosvalidos/eleitores)*100}% de votos válidos, {(votobranco/eleitores)*100}% de votos brancos e {(votonulo/eleitores)*100}% de votos nulos.");
