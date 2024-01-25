    /*
    Faça um programa que leia um nome de usuário e a sua senha e não
    aceite a senha igual ao nome do usuário, mostrando uma mensagem
    de erro e voltando a pedir as informações.
    */

    class Program
    {
        static void Main(string[] args)
        {
            string usuario, senha;

            do
            {
                Console.WriteLine("Digite o nome do usuário: ");

                usuario = Console.ReadLine() ?? "";

                if(! string.IsNullOrEmpty(usuario)){
                    break;
                }

                Console.WriteLine("Usuário Inválido!");

            } while (true);

            do
            {
                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine() ?? "";

                if((! string.IsNullOrEmpty(senha))  && senha != usuario){
                    break;
                }

                Console.WriteLine("Senha Inválida!");

            } while (true);
        
        }

    }