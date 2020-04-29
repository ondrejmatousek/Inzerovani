using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inzerovani.DomainModel.Model
{
    [Dapper.Contrib.Extensions.Table("Kategorie")]
    [Serializable]
    public class Kategorie
    {
        [Dapper.Contrib.Extensions.Key]
        public int IdKategorie { get; set; }
        [StringLength(255)]
        public string Nazev { get; set; }
        public string ParentId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Kategorie kategorie &&
                   IdKategorie == kategorie.IdKategorie &&
                   Nazev == kategorie.Nazev &&
                   ParentId == kategorie.ParentId;
        }

        public override int GetHashCode()
        {
            int hashCode = 1049376100;
            hashCode = hashCode * -1521134295 + IdKategorie.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nazev);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParentId);
            return hashCode;
        }
    }
}
