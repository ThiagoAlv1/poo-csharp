namespace Zoologico;

public class Leao : Animal
{
    //Construtor
    public Leao(string nome, int idade) : base(nome, idade)
    {
        
    }
    
    public override void FazerBarulho()
    {
        Console.WriteLine("Rugindo!");
    }

    public override string ToString()
    {
        return $"Nome: {nome}, Idade: {idade}, RAAAAAW";
    }
}