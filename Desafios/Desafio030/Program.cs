/*
30. Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do Imposto de Renda, que depende do salário bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do Salário Bruto, mas não é descontado (é a empresa que deposita). O Salário Líquido corresponde ao Salário Bruto menos os descontos. O programa deverá pedir ao usuário o valor da sua hora e a quantidade de horas trabalhadas no mês.
Desconto do IR:
Salário Bruto até 900 (inclusive) - isento
Salário Bruto até 1500 (inclusive) - desconto de 5%
Salário Bruto até 2500 (inclusive) - desconto de 10%
Salário Bruto acima de 2500 - desconto de 20% Imprima na tela as informações, dispostas conforme o exemplo abaixo. No exemplo o valor da hora é 5 e a quantidade de hora é 220.
 Salário Bruto: (5 * 220)  : R$ 1100,00
 (-) IR (5%)               : R$   55,00
 (-) INSS  (10%)           : R$  110,00
 FGTS (11%)                : R$  121,00
 Total de descontos        : R$  165,00
 Salário Liquido           : R$  935,00

*/

class Program
{
    static void Main(string[] args)
    {
        decimal vlrHora, totalHoras, fgts, inss, pctIr, vlrIr, bruto, liquido, descontos;

        do
        {
            System.Console.WriteLine("Digite o valor hora: R$ ");
        } while ((!decimal.TryParse(Console.ReadLine(), out vlrHora)));

        do
        {
            System.Console.WriteLine("Digite o total de horas trabalhadas: R$ ");
        } while ((!decimal.TryParse(Console.ReadLine(), out totalHoras)));

        bruto = vlrHora * totalHoras;

        if(bruto <= 900){
            pctIr = 0;
        }
        else if(bruto <= 1500){
            pctIr = 5;
        }
        else if(bruto <= 2500){
            pctIr = 10;
        }
        else{
            pctIr = 20;
        }

        vlrIr     = bruto * (pctIr/100);
        inss      = bruto * (decimal)0.10;
        fgts      = bruto * (decimal)0.11;
        descontos = vlrIr + inss;
        liquido   = bruto - descontos;

        System.Console.WriteLine($"Salário Bruto: ({vlrHora:F2} * {totalHoras:F2}): R$ {bruto:F2}");
        System.Console.WriteLine($"IR ({pctIr}%)                      : R$ {vlrIr:F2}");
        System.Console.WriteLine($"INSS (10%)                    : R$ {inss:F2}");
        System.Console.WriteLine($"FGTS (11%)                    : R$ {fgts:F2}");
        System.Console.WriteLine($"Total de descontos            : R$ {descontos:F2}");
        System.Console.WriteLine($"Salário Líquido               : R$ {liquido:F2}");
    }

}