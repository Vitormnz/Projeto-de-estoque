class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    // Adiciona um produto ao estoque
    public void AdicionarProduto(string nome, decimal preco, int quantidade)
    {
        // Verifica se o produto já existe
        foreach (var produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Produto já existe no estoque.");
                return;
            }
        }

        produtos.Add(new Produto(nome, preco, quantidade));
        Console.WriteLine("Produto adicionado com sucesso!");
    }

    // Exibe todos os produtos no estoque
    public void ExibirEstoque()
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio.");
            return;
        }

        Console.WriteLine("Estoque atual:");
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {produtos[i]}");
        }
    }

    // Alterar o preço de um produto
    public void AlterarPreco(string nome, decimal novoPreco)
    {
        foreach (var produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                produto.Preco = novoPreco;
                Console.WriteLine("Preço alterado com sucesso!");
                return;
            }
        }
        Console.WriteLine("Produto não encontrado.");
    }

    // Remover um produto
    public void RemoverProduto(string nome)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                produtos.RemoveAt(i);
                Console.WriteLine("Produto removido com sucesso!");
                return;
            }
        }
        Console.WriteLine("Produto não encontrado.");
    }

    // Buscar produto por nome
    public void BuscarProduto(string nome)
    {
        foreach (var produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(produto);
                return;
            }
        }
        Console.WriteLine("Produto não encontrado.");
    }
}

