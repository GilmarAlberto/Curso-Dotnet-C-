/*
41.Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar. O resultado da operação deve ser acompanhado de uma frase que diga se o número é:
a. positivo ou negativo;
b. inteiro ou decimal.
c. par ou impar.

*/

class Program
{
    static void Main(string[] args)
    {
        float num1 = 0, num2 = 0, result = 0;
        char oper;

        do
        {
            Console.WriteLine("Digite um número: ");
        } while ((!float.TryParse(Console.ReadLine(), out num1)));
        

        do
        {
            Console.WriteLine("Digite um número: ");
        } while ((!float.TryParse(Console.ReadLine(), out num2)));

        Console.WriteLine("Digite a operação (+, -, *, /): ");
        
        
        if (char.TryParse(Console.ReadKey().KeyChar.ToString(), out oper)){
            Console.WriteLine();

            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                     if (num2 != 0)
                     {
                        result = num1 / num2;
                        break;
                     }
                     else
                     {
                        Console.WriteLine("Divisão por zero não é permitida!");
                        return;
                     }
                default:
                    Console.WriteLine("Operação Inválida!");
                    return;
            }

            if(result == (int)result){
                Console.WriteLine($"O resultado foi {result}, que é inteiro!");

                if(result != 0){
                    if(result % 2 == 0){
                        Console.WriteLine("O resultado é par!");
                    }else{
                        Console.WriteLine("O resultado é impar!");
                    }
                }
            }else{
                Console.WriteLine($"O resultado foi {result:F2}, que é decimal!");
            }

            if(result == 0){
                Console.WriteLine("O resultado é igual a zero!");
            }else if(result > 0){
                Console.WriteLine("O resultado é positivo!");
            }else{
                Console.WriteLine("O resultado é negativo!");
            }

        }else{
            Console.WriteLine("Entrada incorreta!");
        }
        
    }
}