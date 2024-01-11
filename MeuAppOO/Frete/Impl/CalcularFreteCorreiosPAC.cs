namespace MeuAppOO.Frete.Impl
{
    public class CalcularFreteCorreiosPAC : CalcularFreteCorreios
    {
        public override string Nome()
        {
            return "PAC";
        }

        public override int Prazo()
        {
            return 5;
        }

        public override decimal Valor()
        {
            return 1.97M;
        }
    }
}
