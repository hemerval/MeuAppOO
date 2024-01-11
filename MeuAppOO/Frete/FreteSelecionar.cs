using MeuAppOO.Frete.Impl;

namespace MeuAppOO.Frete
{
    public class FreteSelecionar
    {
        public static CalcularFreteCorreios Informarfrete()
        {

            Console.WriteLine("selecione a opção de frete: 1 - pac, 2 - Sedex.".ToUpper());

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    return new CalcularFreteCorreiosPAC();
                case "2":
                    return new CalcularFreteCorreiosSedex();
                default:
                    return Informarfrete();
            }
        }
    }
}
