using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ComissoesVendedores
    {
        [Display(Name = "Nome do vendedor")]
        public string NmeVendedor { get; set; }

        [Display(Name = "Quantidade de veículos vendidos")]
        public Nullable<int> QtdVendas { get; set; }

        [Display(Name = "Quantidade de vales combutíveis emitidos")]
        public Nullable<int> QtdVales { get; set; }

        [Display(Name = "Total em vendas")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> VlrTotalVendas { get; set; }

        [Display(Name = "Total da comissão")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> VlrTotalComissao { get; set; }

    }
}