using MeuAppOO.Pagamento.Impl;

namespace MeuAppOO.Pagamento
{
    public class PagamentoSelecionar
    {

        public static IPagamento InfomrmarPagamento()
        {

            Console.WriteLine("selecione uma forma de pagamento: 1 - pix, 2 - cartao de credito, 3 - cartão de débito.".ToUpper());

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    return new PagamentoPix();

                case "2":
                    return new PagamentoCartaoCredito();

                case "3":
                    return new PagamentoCartaoDebito();

                default:
                    return InfomrmarPagamento();
            }
        }
    }
}
