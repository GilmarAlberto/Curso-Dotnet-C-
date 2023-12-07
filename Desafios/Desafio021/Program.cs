/*
21. Faça um Programa que verifique se uma letra digitada é "F" ou "M". Conforme a letra escrever: F -Feminino, M- Masculino, Sexo Inválido
*/

class Program
{
    static void Main(string[] args)
    {
        char sexo;

        System.Console.Write("Sexo [M/F]: ");
        // Lê o caractere diretamente sem precisar pressionar Enter
        char.TryParse(Console.ReadKey().KeyChar.ToString(), out sexo);

        if (sexo != '\0')
        {
            if (char.ToUpper(sexo) == 'M')
            {
                System.Console.WriteLine("\nM - Masculino");
            }
            else if (char.ToUpper(sexo) == 'F')
            {
                System.Console.WriteLine("\nF - Feminino");
            }
            else
            {
                System.Console.WriteLine("\nSexo Inválido");
            }
        }
        else
        {
            System.Console.WriteLine("\nNenhuma entrada foi fornecida");
        }
     
    }

}

