using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem riri = new Personagem();
            riri.nome = "Riri Williams";
            riri.idade = 18;
            riri.armadura = "Iron Heart";
            Console.WriteLine(riri.nome);
            Console.WriteLine(riri.idade);
            Console.WriteLine(riri.armadura);
            Console.WriteLine("Atacou + "+riri.atacar(50f, 20f));
        }
    }
}
