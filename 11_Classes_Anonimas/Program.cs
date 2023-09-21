public class Program
{

    public static void Main()
    {
        var pessoa1 = new {
            nome = "João",
            idade = 20
        };
        var pessoa2 = new {
            nome = "Maria",
            idade = 17
        };
        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");

    Console.WriteLine("Digite o modelo do carro");
    string modeloDigitado = Console.ReadLine();
     Console.WriteLine("Digite o marca do carro");
    string marcaDigitado = Console.ReadLine();
     Console.WriteLine("Digite o ano do carro");
    string anoDigitado = Console.ReadLine();
        var carro1 = new {
            modelo = modeloDigitado,
            marca = marcaDigitado,
            ano = anoDigitado
        };
        
        Console.WriteLine($"Meu carro da marca {carro1.marca} modelo {carro1.modelo} e ano {carro1.ano}");

    
    }
}