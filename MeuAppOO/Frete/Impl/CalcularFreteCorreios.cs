namespace MeuAppOO.Frete.Impl
{
    public abstract class CalcularFreteCorreios : ICalcularFrete
    {
        public abstract string Nome();
        public abstract decimal Valor();
        public abstract int Prazo();
        public OpcaoFrete Calcular(Carrinho carrinho)
        {
            var nomeServico = Nome();
            if (String.IsNullOrEmpty(nomeServico))
            {
                throw new ArgumentException("Nome do Frete inválido".ToUpper());
            }
            else
            {
                return new OpcaoFrete(Nome(), Valor(), Prazo());
            }
        }
    }
}
