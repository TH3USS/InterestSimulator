namespace InterestSimulator.Models
{
    public class SimuladorJuros
    {
        public double CapitalInicial { get; set; }
        public double TaxaJuros { get; set; }
        public int Periodo { get; set; }
        public double ValorFinal { get; set; }

        // Método para calcular juros simples
        public void CalcularJurosSimples()
        {
            ValorFinal = CapitalInicial * (1 + (TaxaJuros / 100) * Periodo);
        }

        // Método para calcular juros compostos
        public void CalcularJurosCompostos()
        {
            ValorFinal = CapitalInicial * Math.Pow((1 + TaxaJuros / 100), Periodo);
        }
    }
}
