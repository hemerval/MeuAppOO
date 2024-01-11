namespace MeuAppOO
{
    public class Item
    {
        private string _Nome { get; set; }
        private int _Quantidade { get; set; }
        private decimal _Preco { get; set; }
        private decimal _Total { get; set; }

        public Item(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public string Nome
        {
            get { return _Nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("O nome do item é invalido!".ToUpper());
                }
                else
                {
                    _Nome = value.ToUpper();
                }
            }
        }
        public int Quantidade
        {
            get { return _Quantidade; }
            set
            {
                if (value <= 0)
                {
                    _Quantidade = 1;
                }
                else
                {
                    _Quantidade = value;
                }
            }
        }
        public decimal Preco
        {
            get { return _Preco; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("O Preço do item é invalido!".ToUpper());
                }
                else
                {
                    _Preco = value;
                }
            }
        }

        public decimal Total
        {
            get
            {
                _Total = Quantidade * Preco;
                return _Total;
            }
        }
    }
}
