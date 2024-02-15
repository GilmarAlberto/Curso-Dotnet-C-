/*
Faça um programa que imprima na tela os números de 1 a 20, um
abaixo do outro. Depois modifique o programa para que ele mostre os
números um ao lado do outro.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Um embaixo do outro");
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Na mesma linha");

        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + " ");
        }

     
    }

}