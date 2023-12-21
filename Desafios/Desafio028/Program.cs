/*
28.Faça um Programa que pergunte em que turno você estuda. Peça para digitar M-matutino ou V-Vespertino ou N- Noturno. Imprima a mensagem "Bom Dia!", "Boa Tarde!" ou "Boa Noite!" ou "Valor Inválido!””. conforme o caso.
*/

class Program
{
    static void Main(string[] args)
    {
        char letra;
        string msg;

        System.Console.WriteLine("Digite o turno que você estuda (M-matutino ou V-Vespertino ou N- Noturno): ");

        if(char.TryParse(Console.ReadKey().KeyChar.ToString(), out letra)){

            letra = char.ToUpper(letra);

            switch(letra){
                case 'M': {
                    msg = "\nMatutino";
                    break;
                }
                case 'V': {
                    msg = "\nVespertino";
                    break;
                }
                case 'N': {
                    msg = "\nNoturno";
                    break;
                }
                default:{
                    msg = "\nOpção Inválida";
                    break;
                }

            }

            System.Console.WriteLine(msg);
        }
        else{
            System.Console.WriteLine("Entrada não é uma letra");
        }
   
    }

}