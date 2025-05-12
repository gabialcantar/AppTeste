using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTeste.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricãção")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo")]
        public int AnoModelo { get; set; }

        // relação virtual de consumo na query 
        public ICollection<Consumo> Consumos { get; set; }
    }
}
