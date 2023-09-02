using System.Globalization;

namespace Zoologico;

public abstract class Animal
{
    public Animal(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
    
    public string nome;
    public int idade;


    public abstract void FazerBarulho();


}