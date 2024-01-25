/*
Faça um programa que leia e valide as seguintes informações:
a. Nome: maior que 3 caracteres;
b. Idade: entre 0 e 150;
c. Salário: maior que zero;
d. Sexo: 'f' ou 'm';
e. Estado Civil: 's', 'c', 'v', 'd';
*/

class Program
{
    static void Main(string[] args)
    {
        string nome, sexo, estadoCivil;
        int idade;
        decimal salario;

        do
        {
            Console.WriteLine("Nome: ");

            nome = Console.ReadLine() ?? "";
            
            if(nome.Length > 3)
            {
                break;
            }

            Console.WriteLine("Nome Inválido!");
        } while (true);
     
        do{
            Console.WriteLine("Idade [0-150]: ");
            
            if(int.TryParse(Console.ReadLine(), out idade) && idade >= 0 && idade <= 150){
                break;
            }

            Console.WriteLine("Idade inválida!");
        }while (true);

        do
        {
            Console.WriteLine("Salário [>0]: ");

            if(decimal.TryParse(Console.ReadLine(), out salario) && salario > 0){
                break;
            }

            Console.WriteLine("Salário Inválido!");
            
        } while (true);

        do
        {
            Console.WriteLine("Sexo [M/F]: ");

            sexo = Console.ReadLine() ?? " ";

            sexo = sexo.ToUpper();

            if(sexo == "M" || sexo == "F")
            {
                break;
            }

            Console.WriteLine("Sexo Inválido!");
            
        } while (true);

        do
        {
            Console.WriteLine("Estado Civil [s/c/v/d]");

            estadoCivil = Console.ReadLine() ?? " ";

            estadoCivil = estadoCivil.ToUpper();

            if(estadoCivil == "S" || estadoCivil == "C" || estadoCivil == "V" || estadoCivil == "D")
            {
                break;
            }

            Console.WriteLine("Estado Civil inválido!");

        } while (true);

    }

}