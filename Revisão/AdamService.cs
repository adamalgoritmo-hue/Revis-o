using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public static class AdamService
    {
        public static List<Adam> BancoDados = new List<Adam>();
        public static void Adicionar()
        {
            Adam hab = new Adam();
            hab.Id = BancoDados.Count > 0 ? BancoDados.Count + 1 : 1;
            Console.WriteLine("Usuário seu nome:");
            hab.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            hab.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja adicinar habilidades??");
            string resposta = Console.ReadLine();
            while (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite a habilidade da questão que deseja adicionar");
                hab.habilidades.Add(Console.ReadLine());
                Console.WriteLine("Deseja adicionar mais habilidades? Digite sim ou nao?");
                resposta = Console.ReadLine();
            }
            Console.WriteLine("Deseja adicionar a quantidade de habilidades listadas? Digite sim ou nao?");
            resposta = Console.ReadLine();
            while (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite a habilidade que deseja adicionar");
                hab.lista.Add(char.Parse(Console.ReadLine()));
                Console.WriteLine("Deseja adicionar mais habilidades? Digite sim ou nao?");
                resposta = Console.ReadLine();
            }
            BancoDados.Add(hab);
        }
        public static void ListarHabilidades()
        {
            foreach (Adam item in BancoDados)
            {
                item.ExibirLista();
            }
        }
    }
}
