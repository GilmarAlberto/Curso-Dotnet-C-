/*
31.Faça um Programa que leia um número e exiba o dia correspondente da semana. (1-Domingo, 2- Segunda, etc.), se digitar outro valor deve aparecer valor inválido.

*/

class Program
{
    
    static void Main(string[] args)
    {
        byte num;
        string msg;

        do
        {
            System.Console.WriteLine("Digite  um número da semana: ");
        } while ((!byte.TryParse(Console.ReadLine(), out num)));

        switch (num)
        {
            case 1:{
                msg = "Domingo";
                break;
            }
            case 2:{
                msg = "Segunda-feira";
                break;
            }
            case 3:{
                msg = "Terça-feira";
                break;
            }
            case 4:{
                msg = "Quarta-feira";
                break;
            }
            case 5:{
                msg = "Quinta-feira";
                break;
            }
            case 6:{
                msg = "Sexta-feira";
                break;
            }
            case 7:{
                msg = "Sábado";
                break;
            }
            default:{
                msg = "Opção Inválida";
                break;
            }

        }        
        System.Console.WriteLine(msg);
    }

}