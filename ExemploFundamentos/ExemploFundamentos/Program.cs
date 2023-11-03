// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
//using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PR");
listaString.Add("RJ");

for(int contador = 0; contador < listaString.Count; contador++){
    Console.WriteLine($"Posição {contador} - {listaString[contador]}");
}

int contadorforeach = 0;

foreach(string item in listaString){
    Console.WriteLine($"Posição {contadorforeach++} - {item}");
}















/*int[] arrayInteiros = new int[4];


arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int[] arrayInteirosDobrado = new int[arrayInteiros.Length*2];

Array.Copy(arrayInteiros, arrayInteirosDobrado,arrayInteiros.Length);

Console.WriteLine($"O tamanho da segunda array é {arrayInteirosDobrado.Length}");

Console.WriteLine("Percorrendo o Array com o FOR");

for(int contador = 0; contador < arrayInteiros.Length; contador++){
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]} ");
}

int contadorforeach = 0;

Console.WriteLine("Percorrendo o Array com FOREACH");

foreach(int valor in arrayInteiros){
    Console.WriteLine($"Posição Nº {contadorforeach++} - {valor}");

}*/









/*var pessoa1 = new Pessoa();

Console.WriteLine("Hello World!");

pessoa1.Nome = "Gilmar";    
pessoa1.Idade = 59;
pessoa1.Apresentar();*/

/*int n = 0;
double x;

n++;

n+=1;

Console.WriteLine(n);

n = Convert.ToInt32("5");

Console.WriteLine(n);

x = double.Parse("3,14");

Console.WriteLine(x);

Console.WriteLine(x<3.5);
*/