namespace Zoologico
{
    public class Cachorro : Animal
    {
        //Construtor
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
            
        }
        
        public override void FazerBarulho()
        {
            Console.WriteLine("O cachorro latiu.");
        }
        
        public override string ToString()
        {
            return $"Nome: {nome}, Idade: {idade}, AuAu!";
        }
    }
}