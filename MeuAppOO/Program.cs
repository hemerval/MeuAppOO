
using MeuAppOO;

Console.WriteLine("#################### - INICIO - ##########");

#region Item
Item lapiz = new Item("Lapiz", 0, 1.99M);
Item caneta = new Item("Caneta", 2, 1.98M);
Item borracha = new Item("Borracha", 3, 1.97M);
Item caderno = new Item("Caderno", 4, 1.96M);
/*
List<Item> listItem = new List<Item>();
listItem.Add(lapiz);
listItem.Add(caneta);
listItem.Add(borracha);
listItem.Add(caderno);

foreach (Item item in listItem)
{
    Console.WriteLine($"Nome: {item.Nome}, Quantidade: {item.Quantidade}, Preço: {item.Preco}, Total: {item.Total}!");
}
*/

#endregion

#region Carrinho
Carrinho carrinho = new Carrinho();
carrinho.AdicionarItem(lapiz);
carrinho.AdicionarItem(caneta);
carrinho.AdicionarItem(borracha);
carrinho.AdicionarItem(caderno);

foreach (Item item in carrinho.Items)
{
    while (item.Nome.Length <= 10) item.Nome += " ";

    Console.WriteLine($"Nome: {item.Nome}, Quantidade: {item.Quantidade}, Preço: {item.Preco.ToString("C")}, Total: {item.Total}!".ToUpper());
}

Console.WriteLine();
Console.WriteLine($"Quantidade total de itens do carrinho = {carrinho.Quantidade}!".ToUpper());
Console.WriteLine($"Valor total de itens do carrinho = {carrinho.Total.ToString("C")}!".ToUpper());

#endregion

Console.WriteLine("#################### - FINAL - ##########");

Console.ReadLine();
