//Classe Pai que será herdada - SuperClsse
class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
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
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
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