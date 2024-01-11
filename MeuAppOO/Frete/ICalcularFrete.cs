using MeuAppOO.Frete.Impl;

namespace MeuAppOO.Frete
{
    public interface ICalcularFrete
    {
        OpcaoFrete Calcular(Carrinho carrinho);
    }
}
