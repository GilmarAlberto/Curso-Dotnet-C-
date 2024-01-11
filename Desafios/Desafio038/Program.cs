    /*
    38.Faça um Programa para um caixa eletrônico. O programa deverá
    perguntar ao usuário a valor do saque e depois informar quantas notas de cada valor serão fomecidas. As notas disponíveis serão as de 1, 5, 10, 50 e 100 reais. O valor mínimo é de 10 reais e o máximo de 600 reais. O programa não deve se preocupar com a quantidade de notas existentes na máquina.
    Exemplo 1: Para sacar a quantia de 256 reais, o programa fornece duas notas de 100, uma nota de 50, uma nota de 5 e uma nota de 1;
    Exemplo 2: Para sacar a quantia de 399 reais, o programa fornece três notas de 100, uma nota de 50, quatro notas de 10, uma nota de 5 e quatro notas de 1.

    */

    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, centena, cincodez, dezena, cincouni, unidade, vlrtmp;

            do
            {
                System.Console.WriteLine("Digite um valor entre 10 e 600: ");
            } while ((!int.TryParse(Console.ReadLine(), out valor)));

            if(valor < 10 || valor > 600){
                System.Console.WriteLine("Valor inválido!");
                return;
            }

            centena  = valor / 100;
            vlrtmp   = valor - (centena*100);
            cincodez = vlrtmp / 50;
            vlrtmp  -= cincodez * 50;
            dezena   = vlrtmp / 10;
            vlrtmp  -= dezena * 10;
            cincouni = vlrtmp / 5;
            unidade  = vlrtmp - (cincouni * 5);

            if(centena > 0){
                System.Console.WriteLine($"Notas de cem: {centena}");
            }

            if(cincodez > 0){
                System.Console.WriteLine($"Notas de cinquenta: {cincodez}");
            }

            if(dezena > 0){
                System.Console.WriteLine($"Notas de dez: {dezena}");
            }

            if(cincouni > 0){
                System.Console.WriteLine($"Notas de cinco: {cincouni}");
            }

            if(unidade > 0){
                System.Console.WriteLine($"Notas de um: {unidade}");
            }
        }

    }