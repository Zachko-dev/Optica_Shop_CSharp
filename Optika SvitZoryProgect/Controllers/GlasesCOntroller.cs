using Microsoft.AspNetCore.Mvc;
using Optika_SvitZoryProgect.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optika_SvitZoryProgect.Controllers
{
    public class GlasesController:Controller
    {
        private readonly IAllGlases _allGlases;
        private readonly IGlasesCstegory _allCategorys;

        public GlasesController(IAllGlases iallglases,IGlasesCstegory iGlassCat)
        {
            _allGlases = iallglases;
            _allCategorys = iGlassCat;
        }
        public ViewResult List()
        {
            var glases = _allGlases.Glasess;
                return View(glases);
        }
    }
}
