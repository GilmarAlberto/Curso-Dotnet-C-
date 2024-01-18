/*
42.Faça um programa que faça 5 perguntas para uma pessoa sobre um
crime. As perguntas são:
Telefonou para a vítima?
Esteve no local do crime?”
Mora perto da vítima?
Devia para a vítima?
Já trabalhou com a vítima? 
O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ele será classificado como "Inocente",

*/

class Program
{
    static void Main(string[] args)
    {
        int    contador = 0;
        string resposta;

        Console.WriteLine("Telefonou para a vítima?");
        resposta  = Console.ReadLine() ?? "N";
        contador += (resposta.ToUpper()[0] == 'S' ? 1 : 0 );         
        
        Console.WriteLine("Esteve no local do crime?");
        resposta  = Console.ReadLine() ?? "N";
        contador += (resposta.ToUpper()[0] == 'S' ? 1 : 0 );         
        
        Console.WriteLine("Mora perto da vítima?");
        resposta  = Console.ReadLine() ?? "N";
        contador += (resposta.ToUpper()[0] == 'S' ? 1 : 0 );         
        
        Console.WriteLine("Devia para a vítima?");
        resposta  = Console.ReadLine() ?? "N";
        contador += (resposta.ToUpper()[0] == 'S' ? 1 : 0 );         
        
        Console.WriteLine("Já trabalhou com a vítima?");
        resposta  = Console.ReadLine() ?? "N";
        contador += (resposta.ToUpper()[0] == 'S' ? 1 : 0 );         
        
        switch(contador){
            case 2:
                Console.WriteLine("Suspeito!");
                break;
            case 3:
            case 4:
                Console.WriteLine("Cumplice!");
                break;
            case 5:
                Console.WriteLine("Assassino!");
                break;
            default:
                Console.WriteLine("Inocente");
                break;
        }

    }

}