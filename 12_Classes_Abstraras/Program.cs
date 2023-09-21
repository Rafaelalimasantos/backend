//Classe Pai que será herdada - SuperClsse
abstract class Animal
{
    public string cor { get; set; }
    public abstract void EmitirSom()
}

//Classe filha que herdara da classe Animal
class Cachorro : Animal
{
    //Sobrescrevendo O método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo");
    }
}

class Gato : Animal
{
    //Sobrescrevendo O método EmitindoSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miau miau");
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando!");
    }
}

class Program
{
    public static void Main()
    {
        /*
        //Não e permitido criar um objeto de uma classe abstrata
        //Só podemos criar de sua classe derivada
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        */

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();

        //meuCachorro.Ronronar(); //Não posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}