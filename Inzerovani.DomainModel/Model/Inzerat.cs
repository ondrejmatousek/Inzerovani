using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inzerovani.DomainModel.Model
{
    [Dapper.Contrib.Extensions.Table("Inzerat")]
    [Serializable]
    public class Inzerat
    {
        [Dapper.Contrib.Extensions.Key]
        public int IdInzerat { get; set; }
        [StringLength(255)]
        public string NazevInzeratu { get; set; }
        public int CisloInzeratu { get; set; }
        public Kategorie Kategorie { get; set; }
        public DateTime DatumVytvoreni { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Inzerat inzerat &&
                   IdInzerat == inzerat.IdInzerat &&
                   NazevInzeratu == inzerat.NazevInzeratu &&
                   CisloInzeratu == inzerat.CisloInzeratu &&
                   EqualityComparer<Kategorie>.Default.Equals(Kategorie, inzerat.Kategorie) &&
                   DatumVytvoreni == inzerat.DatumVytvoreni;
        }

        public override int GetHashCode()
        {
            int hashCode = 666039813;
            hashCode = hashCode * -1521134295 + IdInzerat.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NazevInzeratu);
            hashCode = hashCode * -1521134295 + CisloInzeratu.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Kategorie>.Default.GetHashCode(Kategorie);
            hashCode = hashCode * -1521134295 + DatumVytvoreni.GetHashCode();
            return hashCode;
        }
    }
}
