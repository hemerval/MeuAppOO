namespace MeuAppOO.Pagamento
{
    public interface IPagamento
    {
        void ProcessarPagamento(Carrinho carrinho);
    }
}
