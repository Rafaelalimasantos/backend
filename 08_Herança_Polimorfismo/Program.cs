using Sesi.Models;

class Program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome = "Bichano";
        meuGato.cor = "Preto";
        meuGato.idade = 2;
        meuGato.especie = "Infins";
        meuGato.genero = "macho";
        meuGato.peso = 3;
        meuGato.EmitirSom();

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "Palhaço";
        meuPeixe.cor = "Laranja";
        meuPeixe.tamanho = 0.20M;
        meuPeixe.peso = 0.100M;
        
    }
}