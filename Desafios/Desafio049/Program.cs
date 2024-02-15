/*
Altere o programa anterior permitindo ao usuário informar as
populações e as taxas de crescimento iniciais. Valide a entrada e
permita repetir a operação.
*/

class Program
{
    static void Main(string[] args)
    {
        

        while (true)
        {
            int    populacaoA;
            int    populacaoB;
            double crescimentoA;
            double crescimentoB;
            int    anos = 0;

            do
            {
                Console.WriteLine("População da cidade A. 0 para sair: ");

                if(int.TryParse(Console.ReadLine(), out populacaoA) && populacaoA >= 0){
                    break;
                }
            } while(true);

            if(populacaoA == 0){
                break;
            }

            do
            {
                Console.WriteLine("População da cidade B: ");
                if(int.TryParse(Console.ReadLine(), out populacaoB) && populacaoB > populacaoA){
                    break;
                }

                Console.WriteLine($"Populaçao B deve ser maior que {populacaoA}");
            } while (true);

            do
            {
                Console.WriteLine("Taxa de crescimento da cidade A: ");

                if(double.TryParse(Console.ReadLine(), out crescimentoA ) && crescimentoA > 0){
                    break;
                }

                Console.WriteLine("Taxa de crescimento deve ser maior que zero!");

            } while (true);

            do
            {
                Console.WriteLine("Taxa de crescimento da cidade B");

                if(double.TryParse(Console.ReadLine(), out crescimentoB) && crescimentoB < crescimentoA){
                    break;
                }

                Console.WriteLine($"Taxa de Crescimento tem que ser menor que {crescimentoA}");
            } while (true);

            while(populacaoA <= populacaoB){
                populacaoA = (int)Math.Round(populacaoA * crescimentoA);
                populacaoB = (int)Math.Round(populacaoB * crescimentoB);
                anos       += 1;
            }

            Console.WriteLine($"Demorará {anos} anos para que a cidade A passe a cidade B");
                
        }
     
    }

}