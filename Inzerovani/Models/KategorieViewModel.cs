using System.ComponentModel.DataAnnotations;

namespace Inzerovani.Models
{
    public class KategorieViewModel
    {
        [Key]
        public int IdKategorie { get; set; }
        [Display(Name = "Název Kategorie")]
        public string Nazev { get; set; }
        public string ParentId { get; set; }
    }
}