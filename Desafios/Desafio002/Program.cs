/*
2. Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].

*/
Console.WriteLine("Digite um número");

string userInput = Console.ReadLine();

if (userInput != null && int.TryParse(userInput, out int num))
{
    Console.WriteLine($"O número informado foi {num}");
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
}