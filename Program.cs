//Exemplo 01 --> Ler e escrever resultados 


 //  || --> or
 //  && --> and

/* Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");
Console.Write("Digite o ano do seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2023 - year;
Console.WriteLine($"Você tem {age} anos.");

if (age >= 18 && name == "Igor") {
    Console.WriteLine("Você é maior de idade.");
} else {
    Console.WriteLine("Você é menor de idade.");
} */



class Program
{    
    static void Main() {        
        string[] names = { "Igor", "Adrieli", "Valquiria" };

        //Exemplo 02 --> Loop for         
        /*for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        } */

        //Comparando string com equals e ignorando o Case Sensitive
        if (string.Equals(names[0], "igor", StringComparison.OrdinalIgnoreCase)) {
            Console.WriteLine("Igual");
        }        

        //Exemplo 03 --> Loop for each
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }        

        string name1 = "Igor";
        Console.WriteLine(name1.Length);
        Console.WriteLine(name1.EndsWith("r"));
        Console.WriteLine(name1.StartsWith("z"));

        int i = 10;
        //Try Parse tenta fazer a conversão de um valor string para Integer.
        if(int.TryParse("42", out int x)) {
            Console.WriteLine("Sucesso!");
        } else {
            Console.WriteLine("Erro!");
        }
        Console.WriteLine(x);
    }
}
