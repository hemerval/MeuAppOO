namespace MeuAppOO.Pagamento.Impl
{
    public class PagamentoCartaoCredito : IPagamento
    {
        public void ProcessarPagamento(Carrinho carrinho)
        {
            Console.WriteLine($"Pagamento efetuado via Cartão de Crédito. Total = {carrinho.Total.ToString("C")}".ToUpper());
        }
    }
}

