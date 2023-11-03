/*
3. Faça um Programa que peça dois números e imprima a soma.
*/
int num1, num2;

do
{
    Console.WriteLine("Digite o primeiro número");
} while (!int.TryParse(Console.ReadLine(), out num1));

do
{
    Console.WriteLine("Digite o segundo número");
} while (!int.TryParse(Console.ReadLine(), out num2));

Console.WriteLine($"A soma de {num1} + {num2} é igual a {num1 + num2}");
