using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao_de_pagamentos.Models
{
    public class Pagamento
    {

        public int Id { get; set; }

        [Display(Name = "Processo")]
        public string Processo { get; set; }

        [Display(Name = "Contrato")]
        public string Contrato { get; set; }

        [Display(Name = "Responsável")]
        public string Responsavel { get; set; }

        [Display(Name = "Gestor Substituto")]
        public string Substituto { get; set; }

        [Display(Name = "Assunto")]
        public string Assunto { get; set; }

        [Display(Name = "Fornecedor")]
        public string Fornecedor { get; set; }

        [Display(Name = "Dias para vencimento")]
        public int DiasParaVencimento { get; set; }

        [Display(Name = "Data de Vencimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DataVencimento { get; set; }

        [Display(Name = "Origem de Documento Fiscal")]
        public string OrigemDocumentoFiscal { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Valor Global do Contrato")]
        public decimal ValorGlobalContrato { get; set; }
    }
}
