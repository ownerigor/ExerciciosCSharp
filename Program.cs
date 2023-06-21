//Exercício 01
Console.WriteLine("Olá, mundo!");

//Exercício 02
Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Boas vindas, {name}!");

//Exercício 03
Console.WriteLine("Vamos fazer a média de 3 números inteiros.");

Console.WriteLine("Digite o 1º número: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 2º número: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o 3º número: ");
int n3 = int.Parse(Console.ReadLine());

int result = (n1 + n2 + n3) / 3;

Console.WriteLine($"A média desses três números é: {result}"); 

//Exercício 04
Console.WriteLine("Vamos verificar se o número que você digitou é par ou ímpar.");
Console.Write("Digite um número: ");
int number = int.Parse(Console.ReadLine());


if (number % 2 == 0) {
    Console.WriteLine("O número é par!");
} else {
    Console.WriteLine("O número é ímpar!");
}

//Exercício 05
Console.WriteLine("Irei escrever todos os números pares de 0 até o número que você escolher.");
Console.WriteLine("Digite um número: ");
int number1 = int.Parse(Console.ReadLine());

for (int i = 0; i < number1; i += 2)
{
    Console.WriteLine(i);
}

//Exercício 06
Console.WriteLine("Irei calcular o valor fatorial do número que você digitar.");
Console.WriteLine("Digite um número: ");
int number2 = int.Parse(Console.ReadLine());
int fatorial = 1;

for (int i = 1; i <= number2; i++)
{
    fatorial *= 1;    
}
Console.WriteLine($"O valor fatorial deste número é: {fatorial}."); 

//Exercício 07
Console.WriteLine("Irei verificar o número que você digitar é primo ou não.");
Console.WriteLine("Digite um número: ");
int number3 = int.Parse(Console.ReadLine());
bool isPrime = true;

if (number3 <= 1) {
    isPrime = false;    
} else {
    for (int i = 2; i <= Math.Sqrt(number3); i++)
    {
        if (number3 % i == 0) {
            isPrime = false;
            break;
        }
    }
}

if (isPrime) {
    Console.WriteLine("O número é primo!");
} else {
    Console.WriteLine("O número não é primo!");
}

//Exercício 08
Console.WriteLine("Irei exibir a tabela de multiplicação de um determinado número que você escolher.");
Console.Write("Digite um número: ");
int number4 = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++) {
    int result1 = (number4 * i);
    Console.WriteLine($"{number4} x {i} = {result1}");
    }
