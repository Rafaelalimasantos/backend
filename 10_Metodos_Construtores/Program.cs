using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto da classe Pessoa
        /*
        //Instanciando objeto sem metodo construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Adalberto";
        pessoa1.idade = 16;
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Albeto Roberto", 16);
        Pessoa pessoa2 = new Pessoa("Rafaela", 17);
        Pessoa pessoa3 = new Pessoa("Ana Clara", 18);

        //Chamar o método Cantar da classe Pessoa
        pessoa1.Cantar();
        pessoa2.Cantar();
        pessoa3.Cantar();
    }
}