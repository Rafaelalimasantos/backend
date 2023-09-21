using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //Criando uma lista denumeros inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        //Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6); // posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        Console.WriteLine("-----------------------");

        //Criem uma nova lista de nomes e adicionem alguns nomes a ela
        //e exibam a quantidade de nomes que contém nessa lista
        List<string> listaNomes = new List<string>();

        listaNomes.Add("Ricardo");
        listaNomes.Add("Douglas");
        listaNomes.Add("Fabiano");
        listaNomes.Add("Heitor");
        Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes");

        Console.WriteLine("-----------------------");

        //Criando uma lista ja atribuindo valores
        List<int> lNumeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        lNumeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in lNumeros)
        {
            Console.WriteLine(item);
        }

        lNumeros.Remove(2); //Remove o elemento buscando pelo conteúdo
        lNumeros.RemoveAt(4); //Remove o elemento pela posição (índice)
        lNumeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os proximos 2

        foreach (int item in lNumeros)
        {
            Console.WriteLine(item);
        }

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        //Criando uma nova lista com objetos da classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à listaAlunos
        Aluno novoAluno = new Aluno("Marcos", 15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("César", 17));
        listaAlunos.Add(new Aluno("Patricia", 19));
        listaAlunos.Add(new Aluno("Carlos", 20));
        listaAlunos.Add(new Aluno("Alice", 12));

        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }

        //Criando uma nova lista, filtrando e ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome
                        select aluno;
        Console.WriteLine("Lista de alunos maiores de 18 anos");
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }

        //LINQ utilizando Sintaxe de método
        var metodo = listaAlunos
                            .Where(novoAluno => novoAluno.idade < 18)
                            .OrderBy(novoAluno => novoAluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }




    }
}