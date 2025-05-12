using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace AppTeste.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a descrição")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        // relação
        [Display(Name = "Veiculo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
    public enum TipoCombustivel
    {
        [Display(Name = "Gasolina")]
        Gasolina,
        [Display(Name = "Etanol")]
        Etanol
    }
}
