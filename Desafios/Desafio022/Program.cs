/*
22. Faça um Programa que verifique se uma letra digitada é vogal ou consoante.
*/

class Program
{
    static void Main(string[] args)
    {
        char letra;

        System.Console.WriteLine("Digite uma letra: ");

        if(char.TryParse(Console.ReadKey().KeyChar.ToString(), out letra)){

            letra = char.ToUpper(letra);

            switch(letra){
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    System.Console.WriteLine("\nÉ vogal!");
                    break;
                default:
                    System.Console.WriteLine("\nÉ Consoante!");
                    break;

            }
        }
        else{
            System.Console.WriteLine("Entrada não é uma letra");
        }
     
    }

}

