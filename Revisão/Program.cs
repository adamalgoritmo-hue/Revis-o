using System.Runtime.CompilerServices;
using Revisão;
using static Revisão.AdamService;

//Adam opcao = new Adam();
//opcao.Id = 1;
//opcao.nome = "Adam";
//opcao.Habilidades = new List<string>() { "Andar", "Correr", "Jogar", "Editar" };

//opcao.ExibirDados();


//Adam habilidades1 = new Adam();
//habilidades1.Id = 1;
//habilidades1.Nome = "Adam";
//habilidades1.Idade = 19;
//habilidades1.habilidades.Add("1 - Correr");
//habilidades1.habilidades.Add("2 - Editar");

//habilidades1.ExibirLista();

//Adam habilidades2 = new Adam();
//habilidades2.Id = 2;
//habilidades2.Nome = "Adam";
//habilidades2.Idade = 19;
//habilidades2.habilidades.Add("1 - ");
//habilidades2.habilidades.Add("2 - ");

//habilidades2.ExibirLista();




int opcao = 0;
while (opcao != -1)
{
    Console.WriteLine("Digite a operação que deseja realizar:");
    Console.WriteLine("1-  Adicionar");
    Console.WriteLine("2- Listar");
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        AdamService.Adicionar();
    }
    else if (opcao == 2)
    {
        AdamService.ListarHabilidades();
    }
    else
    {
        opcao = -1;
    }
}