namespace Zoologico;

public class Gato : Animal
{
    //Construtor
    public Gato(string nome, int idade) : base(nome, idade)
    {
        
    }
    
    public override void FazerBarulho()
    {
        Console.WriteLine("Miando!");
    }
    
    public override string ToString()
    {
        return $"Nome: {nome}, Idade: {idade}, MIAU!";
    }
}