using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Criando uma variavel aluno1 e instacionando da classe Aluno
        //Criando nosso objeto
        var aluno1 = new Aluno();
        aluno1.nome = "Rafaela";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";

        //Chamando o método da classe Aluno
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Ricardo";
        aluno2.idade = 33;
        aluno2.turma = "3º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();
  

        //Chamar metodo ResumoFaltas

        aluno1.ResumoFaltas();
        aluno2.ResumoFaltas();

    }
}