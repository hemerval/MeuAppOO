namespace MeuAppOO.Pagamento.Impl
{
    public class PagamentoCartaoDebito : IPagamento
    {
        public void ProcessarPagamento(Carrinho carrinho)
        {
            Console.WriteLine($"Pagamento efetuado via Cartão de Débito. Total = {carrinho.Total.ToString("C")}".ToUpper());
        }
    }
}
