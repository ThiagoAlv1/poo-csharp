using System;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Cachorro> cachorros = new List<Cachorro>();

            Cachorro cachorro1 = new Cachorro("Rex", 11);
            Cachorro cachorro2 = new Cachorro("Gil", 12);
            Cachorro cachorro3 = new Cachorro("Rexon", 14);

            cachorros.Add(cachorro1);
            cachorros.Add(cachorro2);
            cachorros.Add(cachorro3);
            
            
            foreach (var cachorro in cachorros)
            {
                Console.WriteLine(cachorro);
            }
            
        }
    }
}