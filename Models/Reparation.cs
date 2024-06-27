using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Express.Models
{
    public class Reparation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date d'intervention")]
        public DateTime DateReparation { get; set; }
        [Required]
        [DisplayName("Type d'intervention")]
        public string TypeIntervention { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Coût des réparations")]
        public float CoutReparation { get; set; }
        public int InventaireId { get; set; }
        public Inventaire? Inventaire { get; set; }
    }
}