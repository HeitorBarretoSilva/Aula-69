//!  ATIVIDADE 1

Console.WriteLine("Nome do produto?");
string? nome = Console.ReadLine();

Console.WriteLine("Quantos desse produto você comprou?");
int QuantidadeComprada = int.Parse(Console.ReadLine());
// int opcao = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual é o preço desse produto?");
int preco = int.Parse(Console.ReadLine());


Console.WriteLine($"Você comprou: {QuantidadeComprada} {nome} por {preco} dando um total {QuantidadeComprada * preco}");