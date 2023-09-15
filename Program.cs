int unidade, centena, dezena;

Console.WriteLine(" --- Decomposição Decimal ---");
Console.WriteLine("");
Console.Write("Digite um número inteiro...: ");
int numero = Convert.ToInt32(Console.ReadLine()!);

unidade = (numero % 100) % 10;
dezena = (numero % 100) / 10;
centena = numero / 100;

Console.Clear();
Console.WriteLine($"O número {numero} possui: ");
Console.WriteLine($" {unidade,5} unidade(s)");
Console.WriteLine($" {dezena,5} dezena(s)");
Console.WriteLine($" {centena,5} centena(s)");

