namespace MeuAppOO
{
    public class Carrinho
    {
        private List<Item> items;

        public Carrinho()
        {
            items = new List<Item>();
        }

        public List<Item> Items
        {
            get { return items; }
        }

        public void AdicionarItem(Item item)
        {
            if (item != null)
                items.Add(item);
        }

        public void RemoverItem(Item item)
        {
            if (item != null)
                items.Remove(item);
        }

        public int Quantidade
        {
            get { return items.Sum(x => x.Quantidade); }
        }
        public decimal Total
        {
            get { return items.Sum(x => x.Quantidade * x.Total); }
        }
    }
}
