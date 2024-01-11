namespace MeuAppOO.Pagamento.Impl
{
    public class PagamentoPix : IPagamento
    {
        public void ProcessarPagamento(Carrinho carrinho)
        {
            Console.WriteLine($"Pagamento efetuado via Pix. Total = {carrinho.Total.ToString("C")}".ToUpper());
        }
    }
}
