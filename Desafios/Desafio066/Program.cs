/*
Faça um programa que peça um número inteiro e determine se ele é
ou não um número primo. Um número primo é aquele que é divisível
somente por ele mesmo e por 1.
*/

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int  num   = rand.Next(2,1001);
        bool primo = true;

        for(int i = 2; i <= Math.Sqrt(num); i++){
            if(num % i == 0){
                primo = false;
                break;
            }
        }

        if (primo){
            Console.WriteLine($"O número {num} é primo!");
        }
        else{
            Console.WriteLine($"O número {num} não é primo!");
        }
     
    }

}