namespace Carros.Models
{
    public class Principal : ConsumoCombustivel
    {
        public List<ConsumoCombustivel> Carros { get; set; }
        public void PrimeirosRegistros()
        {
            Carros = new List<ConsumoCombustivel>
            {
                new ConsumoCombustivel { NumeroDeSerie = 1, Capacidade = 50, CombustivelAtual = 0, Portador = "" },
                new ConsumoCombustivel { NumeroDeSerie = 2, Capacidade = 55, CombustivelAtual = 0, Portador = "" },
                new ConsumoCombustivel { NumeroDeSerie = 3, Capacidade = 40, CombustivelAtual = 0, Portador = "" }
            };
        }
    }
}
