using Inzerovani.DomainModel.Model;
using Inzerovani.Mappers;
using Inzerovani.Models;
using Inzerovani.Models.Inzerat;
using Inzerovani.ServiceLayer;
using Inzerovani.ServiceLayer.Implementace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inzerovani.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInzeratService inzeratService;
        private readonly IMapperWeb autoMapper;
        public HomeController(IInzeratService inzeratService, IMapperWeb autoMapper)
        {
            this.inzeratService = inzeratService;
            this.autoMapper = autoMapper;
        }
        

        // GET: Home
        public ActionResult Index()
        {
            TabulkaInzeratViewModel model = VytvorModelSeSeznamy();
            return View("Index", model);
        }

        public TabulkaInzeratViewModel VytvorModelSeSeznamy()
        {
            List<InzeratViewModel> inzeratViewSeznam = new List<InzeratViewModel>();
            List<Inzerat> inzerat = inzeratService.GetAll().OrderBy(o => o.CisloInzeratu).ToList();

            inzeratViewSeznam = autoMapper.Map(inzerat);
            return new TabulkaInzeratViewModel(inzeratViewSeznam);
        }
    }
}