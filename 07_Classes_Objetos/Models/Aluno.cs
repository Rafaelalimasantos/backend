//O namespace é o nome em que usaremos para fazer referencia quando usarmos
namespace Sesi.Model
{
    //Declarando a classe Aluno
    public class Aluno
    {
        //Declarando os atributos (propriedades) da classe Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        //Declarando um atributo privado
        private int nrFaltas { get; set; }

        //Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas + nr;
        }

        //Metodo ResumoFaltas
    public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
        }

    }
}