using AutoMapper;
using Inzerovani.DomainModel.Model;
using Inzerovani.Models;
using System.Collections.Generic;

namespace Inzerovani.Mappers.Implementace
{
    public class MapperWeb : IMapperWeb
    {
        private readonly IMapper autoMapper;
        public MapperWeb()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Inzerat, InzeratViewModel>()
                .ForMember(dest => dest.KategorieId, opt => opt.MapFrom(scr => scr.Kategorie.IdKategorie));

                cfg.CreateMap<InzeratViewModel, Inzerat>()
                .ForMember(dest => dest.Kategorie, opt => opt.MapFrom(s => new Kategorie() { IdKategorie = s.KategorieId }));

                cfg.CreateMap<Kategorie, KategorieViewModel>();
                cfg.CreateMap<KategorieViewModel, Kategorie>();
            });
            this.autoMapper = config.CreateMapper();

        }
        public InzeratViewModel Map(Inzerat inzerat)
        {
            InzeratViewModel inzeratViewModel = autoMapper.Map<Inzerat, InzeratViewModel>(inzerat);
            return inzeratViewModel;
        }

        public Inzerat Map(InzeratViewModel inzeratViewModel)
        {
            Inzerat inzerat = autoMapper.Map<InzeratViewModel, Inzerat>(inzeratViewModel);
            return inzerat;
        }

        public List<Inzerat> Map(List<InzeratViewModel> inzeratViewModel)
        {
            List<Inzerat> inzerat = autoMapper.Map<List<InzeratViewModel>, List<Inzerat>>(inzeratViewModel);
            return inzerat;
        }

        public List<InzeratViewModel> Map(List<Inzerat> inzeratList)
        {
            List<InzeratViewModel> inzeratViewModel = autoMapper.Map<List<Inzerat>, List<InzeratViewModel>>(inzeratList);
            return inzeratViewModel;
        }
    }
}
