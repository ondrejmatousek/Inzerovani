using Inzerovani.DomainModel.Model;
using Inzerovani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzerovani.Mappers
{
    public interface IMapperWeb
    {
        //Inzerat
        InzeratViewModel Map(Inzerat inzerat);
        Inzerat Map(InzeratViewModel inzeratViewModel);
        List<InzeratViewModel> Map(List<Inzerat> inzerat);
        List<Inzerat> Map(List<InzeratViewModel> inzeratViewModel);

    }
}
