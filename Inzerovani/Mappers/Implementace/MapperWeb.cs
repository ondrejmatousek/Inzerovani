using AutoMapper;
using Inzerovani.DomainModel.Model;
using Inzerovani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
                .ForMember(dest => dest.Kategorie, opt => opt.MapFrom(scr => new Kategorie() { IdKategorie = scr.KategorieId }));
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

        public List<InzeratViewModel> Map(List<Inzerat> inzerat)
        {
            List<InzeratViewModel> inzeratViewModel = autoMapper.Map<List<Inzerat>, List<InzeratViewModel>>(inzerat);
            return inzeratViewModel;
        }
    }
}