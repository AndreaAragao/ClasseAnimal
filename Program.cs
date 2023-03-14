using Projeto01.Entidade;
using System;

namespace Projeto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal meuAnimal;
            meuAnimal = new Animal();

            meuAnimal.Nome = "bob";
            meuAnimal.Raca = "cachorro";

            Animal seuAnimal;
            seuAnimal = new Animal();
            seuAnimal.Nome = "nenem";
            seuAnimal.Raca = "papagaio";

            Animal nossoAnimal;
            nossoAnimal = new Animal();
            nossoAnimal.Nome = "ping";
            nossoAnimal.Raca = "tucano";

        }
    }
}
