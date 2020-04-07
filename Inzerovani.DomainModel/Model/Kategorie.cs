using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.DomainModel.Model
{
    [Serializable]
    public class Kategorie
    {
        public int IdKategorie { get; set; }
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
