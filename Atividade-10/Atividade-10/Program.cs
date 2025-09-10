Console.WriteLine("Qual foi a sua nota da 1ª avaliação?");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("E qual foi a sua nota da 2ª avaliação?");
double nota2 =  double.Parse(Console.ReadLine());
double media = (nota1 + nota2) / 2;
if (media >= 6)
{
    Console.WriteLine("Você está aprovado!");
}
else
{
    Console.WriteLine("Você está reprovado! :(");
}