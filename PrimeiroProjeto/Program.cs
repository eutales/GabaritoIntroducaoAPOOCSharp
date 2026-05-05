using PrimeiroProjeto;

internal class Program
{
    private static void Main(string[] args)
    {
        Instituicao instituicao = new Instituicao();
        Console.WriteLine("Digite o nome da instituição:");
        instituicao.Nome = System.Console.ReadLine();
        System.Console.WriteLine("Informe o endereço da instituição");
        instituicao.Endereco = System.Console.ReadLine();

        System.Console.WriteLine("=====");
        System.Console.WriteLine($"Obrigado por informar os dados para a {instituicao.Nome}");
        System.Console.Write("Pressione qualquer tecla para encerrar");
        System.Console.ReadKey();
    }
}