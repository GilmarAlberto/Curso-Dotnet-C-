/*
44. Uma fruteira está vendendo frutas com a seguinte tabela de preços:
          Até 5 Kg             Acima de 5 Kg 
 Morango R$ 2,50 por Kg        R$ 2,20 por Kg 
 Maçã    R$ 1,80 por Kg        R$ 1,50 por Kg
Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 25,00, receberá ainda um desconto de 10% sobre este total. Escreva um algoritmo para ler a quantidade (em Kg) de morangos e a quantidade (em Kg) de maças adquiridas e escreva o valor a ser pago pelo cliente.

*/

class Program
{
    static void Main(string[] args)
    {
        decimal qtdMorango, qtdMaca, vlrMorango, vlrMaca, totalFrutas, subtotal, vlrTotal;

        Console.WriteLine("Quantidade de Morangos (Kg): ");
        qtdMorango = decimal.Parse(Console.ReadLine() ?? "0.00");

        Console.WriteLine("Quantidade de Maçãs (Kg): ");
        qtdMaca = decimal.Parse(Console.ReadLine() ?? "0.00");

        vlrMorango  = qtdMorango * (qtdMorango > 5m ? 2.20m : 2.50m);
        vlrMaca     = qtdMaca    * (qtdMaca    > 5m ? 1.50m : 1.80m);
        totalFrutas = qtdMorango + qtdMaca;
        subtotal    = vlrMorango + vlrMaca;
        vlrTotal    = subtotal * (totalFrutas > 8m || subtotal > 25.00m ? 0.90m : 1.00m);

        Console.WriteLine($"O valor total a ser pago é R$ {vlrTotal:F2}");

    }

}