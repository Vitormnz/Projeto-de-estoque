class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Exibir Estoque");
            Console.WriteLine("3. Alterar Preço");
            Console.WriteLine("4. Remover Produto");
            Console.WriteLine("5. Buscar Produto");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o preço do produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade do produto: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    estoque.AdicionarProduto(nome, preco, quantidade);
                    break;
                case "2":
                    estoque.ExibirEstoque();
                    break;
                case "3":
                    Console.Write("Digite o nome do produto: ");
                    string nomeAlterar = Console.ReadLine();
                    Console.Write("Digite o novo preço: ");
                    decimal novoPreco = decimal.Parse(Console.ReadLine());
                    estoque.AlterarPreco(nomeAlterar, novoPreco);
                    break;
                case "4":
                    Console.Write("Digite o nome do produto a ser removido: ");
                    string nomeRemover = Console.ReadLine();
                    estoque.RemoverProduto(nomeRemover);
                    break;
                case "5":
                    Console.Write("Digite o nome do produto para busca: ");
                    string nomeBuscar = Console.ReadLine();
                    estoque.BuscarProduto(nomeBuscar);
                    break;
                case "6":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
