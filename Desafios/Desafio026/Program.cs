/*
26. Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre pelo mais barato.

*/

class Program
{
    static void Main(string[] args)
    {
        double preco1, preco2, preco3, menor;
        string prod;

        do
        {
            System.Console.WriteLine("Digite o primeiro produto R$: ");
        } while ((!double.TryParse(Console.ReadLine(), out preco1)));

        do
        {
            System.Console.WriteLine("Digite o segundo produto R$: ");
        } while ((!double.TryParse(Console.ReadLine(), out preco2)));

        do
        {
            System.Console.WriteLine("Digite o terceiro produto R$: ");
        } while ((!double.TryParse(Console.ReadLine(), out preco3)));
     
        menor = preco1;
        prod = "Produto 1";

        if(preco2 < menor){
            menor = preco2;
            prod  = "Produto 2";
        }

        if(preco3 < menor){
            menor = preco3;
            prod  = "Produto 3";
        }

        System.Console.WriteLine($"O menor preço é R$ {menor:F2} do {prod}");
    }

}