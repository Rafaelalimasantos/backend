public class Program
{
    public static void Main()
    {
        //O try serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
        //A execução do bloco e vai para o catch
        try {
        Console.WriteLine("Digite um número inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Você digitou o nº {numero}");
        }
        //Tratando exceção de erro especifica de formato
        catch (FormatException)
        {
            Console.WriteLine($"Digite um número inteiro");
        }
        //Catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //Com o tipo do erro, para melhor compreensão do usuario
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro genético: {erro.Message}");
        }
        finally{
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");
        }

    }
}