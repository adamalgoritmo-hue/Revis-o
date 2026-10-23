using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Rafael
    {
        public string Nome { get; set; }

        public List<string> Habilidades { get; set; }
        public int idade { get; set; }
        public void ExibirDados()
        {
            Console.WriteLine($"Meu nome e {Nome}");
            Console.WriteLine($"Minhas habilidades sao {Habilidades}");
            Console.WriteLine($"Eu tenho {idade}");
        }
    }
    
}
