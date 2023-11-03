/*
4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.
*/

class CalculadoraDeMedias
{
    
    public void CapturarNotas()
    {
        int nota1, nota2, nota3, nota4, media;

        do
        {
            Console.WriteLine("Digite a primeira nota:");
        } while (!int.TryParse(Console.ReadLine(), out nota1));

        do
        {
            Console.WriteLine("Digite a segunda nota:");
        } while (!int.TryParse(Console.ReadLine(), out nota2));

        do
        {
            Console.WriteLine("Digite a terceira nota:");
        } while (!int.TryParse(Console.ReadLine(), out nota3));

        do
        {
            Console.WriteLine("Digite a quarta nota:");
        } while (!int.TryParse(Console.ReadLine(), out nota4));

        media = CalcularMedia(nota1, nota2, nota3, nota4);

        Console.WriteLine($"A media entre {nota1}, {nota2}, {nota3} e {nota4} é igual a {media}");
    }

    private int CalcularMedia(int nota1, int nota2, int nota3, int nota4)
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }
}

class Program
{
    static void Main()
    {
        CalculadoraDeMedias calculadora = new CalculadoraDeMedias();
        calculadora.CapturarNotas();
    }
}


