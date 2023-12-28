/*
34.Faça um programa que calcule as raízes de uma equação do segundo
grau, na forma ax2 + bx + c. O programa deverá pedir os valores de a, b e c e fazer as consistências, informando ao usuário nas seguintes situações:
a. Se o usuário informar o valor de A igual a zero, a equação não é do segundo grau e o programa não deve fazer pedir os demais valores, sendo encerrado;
b. Se o delta calculado for negativo, a equação não possui raizes reais. Informe ao usuário e encerre o programa;
c. Se o delta calculado for igual a zero a equação possui apenas uma raiz real; informe-a ao usuário;
d. Se o delta for positivo, a equação possui duas raiz reais; informe-as ao usuário;

*/

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        double delta, x1, x2;


        do
        {
            System.Console.WriteLine("Digite o valor de a: ");
        } while ((!int.TryParse(Console.ReadLine(), out a)));

        if(a == 0){

            System.Console.WriteLine("Equação não é do Segundo Grau!");

            return;

        }
     
        do
        {
            System.Console.WriteLine("Digite o valor de b: ");
        } while ((!int.TryParse(Console.ReadLine(), out b)));
     
        do
        {
            System.Console.WriteLine("Digite o valor de c: ");
        } while ((!int.TryParse(Console.ReadLine(), out c)));

        delta = (b * b) - 4 * (a * c);

        if(delta < 0){
            System.Console.WriteLine("Equação não possui raízes reais!");
            return;
        }else if(delta == 0){
            System.Console.WriteLine("Equação possui apenas uma raiz real!");
            
            x1 = (-Convert.ToDouble(b)) / (2 * a);

            System.Console.WriteLine($"x1 = x2 = {x1}");
        }else{
            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            System.Console.WriteLine($"x1 = {x1}");
            System.Console.WriteLine($"x2 = {x2}");
        }

    }

}