namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }

        //Criando nosso método construtor
        public Pessoa (string nomePessoa, int idadePessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
        }

        //Métodos da classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
            
        }
    }
}