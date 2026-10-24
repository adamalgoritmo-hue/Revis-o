using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Rafael
    {
        public string Nome;

        public List<string> Habilidades;
        public int idade;
        public void ExibirDados()
        {
            Console.WriteLine($"Meu nome e {Nome}");
            Console.WriteLine($"Minhas habilidades sao {Habilidades}");
            Console.WriteLine($"Eu tenho {idade}");
        }
    }
    
}
