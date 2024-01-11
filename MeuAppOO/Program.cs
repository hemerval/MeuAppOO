
using MeuAppOO;

Console.WriteLine("#################### - INICIO - ##########");

#region Item
Item lapiz = new Item("Lapiz", 0, 1.99M);
Item caneta = new Item("Caneta", 2, 1.98M);
Item borracha = new Item("Borracha", 3, 1.97M);
Item caderno = new Item("Caderno", 4, 1.96M);

Console.WriteLine($" Nome: {lapiz.Nome}, Quantidade: {lapiz.Quantidade}, Preço: {lapiz.Preco}, Total: {lapiz.Total}!");



#endregion

Console.ReadLine();

Console.WriteLine("#################### - FINAL - ##########");
