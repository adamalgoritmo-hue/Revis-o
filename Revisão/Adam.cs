using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Adam
    {
        //public List<string> Habilidades;
        //public int Id;
        //public string nome;

        //public void ExibirDados()
        //{
        //    Console.WriteLine($"Id: {Id}");
        //    Console.WriteLine($"Nome: {nome}");
        //    Console.WriteLine("Habilidades:");
        //    foreach ( string habilidades in Habilidades)
        //    {
        //        Console.WriteLine($"- {habilidades}");
        //    }
        //}

            public int Id { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public List<string> habilidades { get; set; } = new List<string>();
            public List<int> lista { get; set; } = new List<int>();
        public void ExibirLista()
            {
                Console.WriteLine($"Id: {Id}");
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Idade: {Idade}");
                Console.WriteLine($"Habilidades:");
                foreach (string item in habilidades)
                {
                    Console.WriteLine($"- {item}");
            }
            Console.WriteLine("Lista");
            int contador = 0;

            foreach (int l in lista)
            {
                contador++;
                Console.WriteLine($"{contador} - {l}");
            }
        }
    }
}
