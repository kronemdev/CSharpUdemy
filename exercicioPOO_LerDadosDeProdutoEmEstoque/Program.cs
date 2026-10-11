using exercicioPOO_LerDadosDeProdutoEmEstoque;

Produto Produto = new Produto();
Console.WriteLine("=============== Entre com os Dados dos produtos =================");
Console.Write("Nome:");
Produto.Nome = Console.ReadLine();
Console.Write("Preço:");
Produto.Preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade no Estoque:");
Produto.Quantidade = int.Parse(Console.ReadLine());


//Console.WriteLine($"Dados do Produto: {Produto.Nome}, ${Produto.Preco}, Total: ${}");
Console.WriteLine($"Dados do Produto: {Produto} ");
Console.WriteLine(" ");
Console.WriteLine("Digite o Numero de Produtos a Ser Adicionado ao estoque: ");
int padd = int.Parse(Console.ReadLine());
Produto.AdicionarProdutos(padd);
Console.WriteLine(" ");
Console.WriteLine($"Dados Atualizados: {Produto} ");
Console.WriteLine(" ");
Console.WriteLine("Digite o numero de produtos a ser Removido do estoque: ");
int premov = int.Parse(Console.ReadLine());
Produto.RemoverProdutos(premov);
Console.WriteLine(" ");
Console.WriteLine($"Dados Atualidados: {Produto} ");