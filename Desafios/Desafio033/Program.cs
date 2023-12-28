/*
33.Faça um Programa que peça os 3 lados de um triângulo. Oprograma
deverá informar se os valores podem ser um triângulo. Indique, caso os lados formem um triângulo, se o mesmo é: equilátero, isósceles ou escaleno.
 - Dicas:
   - Três lados formam um triângulo quando a soma de quaisquer dois lados for maior que o terceiro;
   - Triângulo Equilátero: três lados iguais;
   - TriânguloIsósceles: quaisquer dois lados iguais;
   - Triângulo Escaleno: três lados diferentes;

*/

class Program
{
    static void Main(string[] args)
    {
        int lado1, lado2, lado3;

        do
        {
            System.Console.WriteLine("Digite o lado 1: ");
        } while ((!int.TryParse(Console.ReadLine(), out lado1)));
     
        do
        {
            System.Console.WriteLine("Digite o lado 2: ");
        } while ((!int.TryParse(Console.ReadLine(), out lado2)));
     
        do
        {
            System.Console.WriteLine("Digite o lado 3: ");
        } while ((!int.TryParse(Console.ReadLine(), out lado3)));

        if(lado1 + lado2 > lado3 &&
           lado1 + lado3 > lado2 &&
           lado2 + lado3 > lado1){

            if(lado1 == lado2 && lado2 == lado3){
                System.Console.WriteLine("Triângulo Equilátero!");
            }else if(lado1 == lado2 ||
                     lado1 == lado3 ||
                     lado2 == lado3){
                System.Console.WriteLine("Triângulo Isósceles");
            }else{
                System.Console.WriteLine("Triângulo Escaleno");
            }

        }else{
            System.Console.WriteLine("Não é triangulo!");
        }
     
    }

}