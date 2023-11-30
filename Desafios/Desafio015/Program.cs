/*
15. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
a. salário bruto.
b. quanto pagou ao INSS.
c. quanto pagou ao sindicato.
d. o salário líquido.
e. calcule os descontos e o salário líquido, conforme a tabela abaixo:

+ Salário Bruto : R$
- IR (11%) : R$
- INSS (8%) : R$
- Sindicato ( 5%) : R$
= Salário Liquido : R$

Obs.: Salário Bruto - Descontos = Salário Líquido.

*/

class Program
{
    static void Main(string[] args)
    {
        double valorHora, horasTrabalhadasMes, salarioBruto, salarioLiquido, desconto, ir, inss, sindicato;

        do
        {
            System.Console.WriteLine("Digite o Valor/Hora: ");
        } while ((!double.TryParse(Console.ReadLine(), out valorHora)));

        do
        {
            System.Console.WriteLine("Digite a quantidade de horas trabalhadas no mês: ");
        } while ((!double.TryParse(Console.ReadLine(), out horasTrabalhadasMes)));

        salarioBruto   = valorHora * horasTrabalhadasMes;
        ir             = salarioBruto * 0.11;
        inss           = salarioBruto * 0.08;
        sindicato      = salarioBruto * 0.05;
        desconto       = ir + inss + sindicato;
        salarioLiquido = salarioBruto - desconto;

        System.Console.WriteLine($"Salário Bruto  : R$ {salarioBruto}");
        System.Console.WriteLine($"IR             : R$ {ir}");
        System.Console.WriteLine($"INSS           : R$ {inss}");
        System.Console.WriteLine($"Sindicato      : R$ {sindicato}");
        System.Console.WriteLine($"Desconto       : R$ {desconto}");
        System.Console.WriteLine($"Salário Líquido: R$ {salarioLiquido}");
    
    }

}

