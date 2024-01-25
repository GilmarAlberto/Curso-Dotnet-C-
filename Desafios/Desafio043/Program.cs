/*
43. Um está vendendo combustíveis com a seguinte tabela de descontos:
. Álcool:
a. até 20 litros, desconto de 3% por litro
b. acima de 20 litros, desconto de 5% por litro
Gasolina:
c. até 20 litros, desconto de 4% por litro
d. acima de 20 litros, desconto de 6% por. Escreva um algoritmo que leia o número de litros vendidos, o tipo de combustível (codificado da seguinte forma: A-álcool, G- gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 2,50 o preço do litro do álcool é R$ 1,90.

*/

class Program
{
    static void Main(string[] args)
    {
        double litros = 0.00, desconto, totalPago, precoLitro;
        char tipo;

        do
        {
            Console.WriteLine("Tipo de Combustível (A-Álcool, G-Gasolina):");
            tipo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine("");
            if( tipo == 'A' || tipo == 'G'){
                break;
            }

            Console.WriteLine("Tipo Inválido! Deve ser A-Álcool ou G-Gasolina");

        } while (true);

        do
        {
            Console.WriteLine("Quantidade de Litros: ");
            litros = double.Parse(Console.ReadLine() ?? "0.00");

            if(litros > 0){
                break;
            }

            Console.WriteLine("Quantidade de Litros deve ser maior que zero!");
        } while (true);

        if(tipo == 'A'){
            precoLitro = 1.9;
            desconto   = (litros > 20 ? 0.95 : 0.97);

        }else{
            precoLitro = 2.5;
            desconto   = (litros > 20 ? 0.94 : 0.96);
        }

        totalPago = litros * precoLitro * desconto;

        Console.WriteLine($"O valor a ser pago é R$ {totalPago:F2}!");
    }

}