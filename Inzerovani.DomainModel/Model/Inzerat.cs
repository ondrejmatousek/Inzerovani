using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.DomainModel.Model
{
    [Serializable]
    public class Inzerat
    {
        public int IdInzerat { get; set; }
        public string NazevInzeratu { get; set; }
        public int CisloInzeratu { get; set; }
        public DateTime DatumVytvoreni { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Inzerat inzerat &&
                   IdInzerat == inzerat.IdInzerat &&
                   NazevInzeratu == inzerat.NazevInzeratu &&
                   CisloInzeratu == inzerat.CisloInzeratu &&
                   DatumVytvoreni == inzerat.DatumVytvoreni;
        }

        public override int GetHashCode()
        {
            int hashCode = 757339360;
            hashCode = hashCode * -1521134295 + IdInzerat.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NazevInzeratu);
            hashCode = hashCode * -1521134295 + CisloInzeratu.GetHashCode();
            hashCode = hashCode * -1521134295 + DatumVytvoreni.GetHashCode();
            return hashCode;
        }
    }
}
