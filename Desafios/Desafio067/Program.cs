/*
.Altere o programa de cálculo dos números primos, informando, caso o
número não seja primo, por quais número ele é divisível.
*/

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int  num   = rand.Next(2,1001);
        bool primo = true, primeiro = true;
        string divisores = "";

        for(int i = 2; i <= (num/2); i++){
            if(num % i == 0){

                if(primeiro){
                    Console.WriteLine($"O número {num} não é primo!");
                    primeiro = false;
                    primo = false;
                }

                divisores += $"{i} ";
            }
        }

        if (primo){
            Console.WriteLine($"O número {num} é primo!");
        }
        else{
            Console.WriteLine($"O número {num} é divisível por {divisores}");
        }
             
    }

}