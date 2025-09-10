Console.WriteLine("Em qual ano estamos?");
int anoatual = int.Parse(Console.ReadLine());
Console.WriteLine("E em qual ano Você nasceu?");
int anonascimento =  int.Parse(Console.ReadLine());
int idade = anoatual -  anonascimento;
if (idade >= 18)
{
    Console.WriteLine("Seu voto é obrigatório a partir desse ano!");
}
else
{
    Console.WriteLine("Seu voto não é obrogatório esse ano!");
}