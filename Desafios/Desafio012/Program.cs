/*
12. Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72.7*altura) - 58

*/

class Program
{
    static void Main(string[] args)
    {
        double altura, peso;

        do
        {
            System.Console.WriteLine("Digite a altura: ");
        } while ((!double.TryParse(Console.ReadLine(), out altura)));

        peso = (72.7 * altura) - 58;

        System.Console.WriteLine($"O peso ideal para uma pessoa com {altura} de altura é {peso}");
    }
}