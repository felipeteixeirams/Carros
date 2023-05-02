using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Carros.Models
{
    [Table("ConsumoCombustivels")]
    public class ConsumoCombustivel
    {
        [Key]
        [Display(Name = "Número de Serie")]
        public int NumeroDeSerie { get; set; }

        [Display(Name = "Capacidade")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Capacidade { get; set; }

        [Display(Name = "Nome do Portador")]
        [Required(ErrorMessage = "Campo Obrigatrio")]
        public string? Portador { get; set; }

        [Display(Name = "Combustível atual")]
        [Required(ErrorMessage = "Campo Obrigatrio")]
        public int CombustivelAtual { get; set; }

        public void Abastecer(int litros)
        {
            if((Capacidade - CombustivelAtual) > litros)
            {
                CombustivelAtual += litros;
            }else {
                CombustivelAtual += (Capacidade - CombustivelAtual);
            }
        }


        public int Rodar()
        {
            Random NumAleatorio = new Random();
            int Consumo;
            if(CombustivelAtual != 0)
            {
                Consumo = NumAleatorio.Next(1, CombustivelAtual);
                CombustivelAtual -= Consumo;
            }else
            {
                Consumo = CombustivelAtual;
            }

            return Consumo;
        }

        public int Contar()
        {
            return CombustivelAtual;
        }


    }
}