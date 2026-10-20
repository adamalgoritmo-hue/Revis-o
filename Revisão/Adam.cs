using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Adam
    {
        public List<string> Habilidades;
        public string nome;

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine("Habilidades:");
            foreach ( string habilidades in Habilidades)
            {
                Console.WriteLine($"- {habilidades}");
            }
        }
    }
}
