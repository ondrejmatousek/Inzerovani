using System;
using System.ComponentModel.DataAnnotations;

namespace Inzerovani.Models
{
    public class InzeratViewModel
    {
        [Key]
        public int IdInzerat { get; set; }
        [Display(Name = "Název Inzerátu")]
        public string NazevInzeratu { get; set; }
        [Display(Name = "Číslo Inzerátu")]
        public int CisloInzeratu { get; set; }
        [Display(Name = "Kategorie")]
        public KategorieViewModel Kategorie { get; set; }
        [Display(Name = "Datum Vytvoření")]
        public DateTime DatumVytvoreni { get; set; }

        public int KategorieId { get; set; }
    }
}
