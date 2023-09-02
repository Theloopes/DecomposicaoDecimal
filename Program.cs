Console.WriteLine(" --- Decomposição Decimal ---");
Console.WriteLine("");
Console.Write("Digite um número inteiro...: ");
int numero = Convert.ToInt32(Console.ReadLine()!);

int resto = numero;

int unidade = resto % 10;
resto /= 10;
int dezena = resto % 10;
resto /= 10;
int centena = resto % 10;

Console.WriteLine($"O número {numero} possui: ");
Console.WriteLine($" {unidade} unidade(s)");
Console.WriteLine($" {dezena} dezena(s)");
Console.WriteLine($" {centena} centena(s)");

