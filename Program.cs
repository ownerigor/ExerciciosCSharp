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
        /* if (string.Equals(names[0], "igor", StringComparison.OrdinalIgnoreCase)) {
            Console.WriteLine("Igual");
        } */       

        //Exemplo 03 --> Loop for each
        /* foreach (string name in names)
        {
            Console.WriteLine(name);
        }        

        string name1 = "Igor";
        Console.WriteLine(name1.Length);
        Console.WriteLine(name1.EndsWith("r"));
        Console.WriteLine(name1.StartsWith("z")); */

        /*int i = 10;
        //Try Parse tenta fazer a conversão de um valor string para Integer.
         if(int.TryParse("42", out int x)) {
            Console.WriteLine("Sucesso!");
        } else {
            Console.WriteLine("Erro!");
        }
        Console.WriteLine(x); */

        //Conversões implicitas e explicitas
        /* int i = 10; //quando coloca-se ? na frente da declaração do tipo, ele se torna um valor anulavel.
        long l = 10;
        int? j = null;

        l = i; //Implicita
        i = (int)l; //Explicita


        string s = l.ToString(); //Conversão que todos os métodos tem.

        Test t = new Test(); //instaciando um objeto
        t.x = 12; //atribuindo valor a algo dentro do objeto

        t = null;
        if (j == null) {
            Console.WriteLine("Nullo");            
        }

        if (j != null) { //operador de desigualdade/diferente
            Console.WriteLine("Não é nullo");
        }

        if (j is null) { //operador is ou também is not null
            Console.WriteLine("Nullo");
        }

        Test t2 = t;
        t2 = new Test(); //instaciando novo objeto da classe Test, agora tenho 2 objetos.
        t2.x = 20;

        Console.WriteLine(t.x); */

        int[] numbers = { 1 };
        string str = null;        

        //Trabalhando com exceptions
        try
        {
            Console.WriteLine(str.Length);
        }
        catch (IndexOutOfRangeException) {
            Console.WriteLine($"Erro IndexOutOfRangeException");
        }        
        catch{
            Console.WriteLine($"Erro");
        }
        //Instaciando o log
        ILogger logger = new FileLogger("mylog.txt");
        BankAccount account1 = new BankAccount("Igor", 100, logger);
        BankAccount account2 = new BankAccount("Adrieli", 100, logger);

        account1.Deposit(-100);
        account2.Deposit(100);

        Console.WriteLine(account2.Balance);
    }
}   

//Criando uma classe teste
class Test {
    public int x;
}

//Classe para criar um arquivo "log.txt" com os logs dentro
class FileLogger : ILogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePath, $"{message}{Environment.NewLine}");
    }
}

//Classe para mostrar os logs no console
class ConsoleLogger : ILogger {

}

//Criando uma interface os logs
interface ILogger {
    void Log(string message) {
        Console.WriteLine($"LOGGER: {message}");
    }
}

//Criando uma classe BankAccount, onde contém 2 atributos.
class BankAccount {
    //atributo name
    private string name;
    private readonly ILogger logger;

    //atributo Balance, ela tem dois métodos, um get e set. 
    public decimal Balance { 
        get; private set;
    }

    //Trabalhando Exceptions
    public BankAccount(string name, decimal balance, ILogger logger) {
        if (string.IsNullOrWhiteSpace(name)) {
            throw new ArgumentException("Nome inválido!", nameof(name));
        }
        if (balance < 0) {
            throw new Exception("Saldo não pode ser negativo.");
        }
        //Retornando os valores da classe BankAccount.
        this.name = name;
        Balance = balance;
        //Retornando o log
        this.logger = logger;
    }

    //Criando uma classe de "depósito", onde irá somar o valor que já contido mais o valor de depósito.
    public void Deposit(decimal amount) {
        if (amount <= 0) {
            logger.Log($"Não é possível depositar {amount} na conta de {name}!");
            throw new Exception("Valor de depósito não pode ser menor ou igual a 0.");            
        }
        Balance += amount;
    }
}
