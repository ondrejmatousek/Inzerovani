using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inzerovani.Models.Inzerat
{
    public class TabulkaInzeratViewModel
    {
        public List<InzeratViewModel> inzeratViewModelSeznam { get; set; }
        public InzeratViewModel inzeratViewModel { get; set; }
        public TabulkaInzeratViewModel()
        {

        }
        public TabulkaInzeratViewModel(List<InzeratViewModel> inzeratViewModelSeznam)
        {
            this.inzeratViewModelSeznam = inzeratViewModelSeznam;
        }
    }
}