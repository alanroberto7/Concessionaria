using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ComissoesController : Controller
    {

        public ActionResult Vendedores()
        {
            var mapper = new Mapper(new MapperConfiguration(o => { o.CreateMap<DAL.ListarComissoesVendedores_Result, Models.ComissoesVendedores>(); }));

            var list = new BLL.ListarComissoesVendedores().GetList();
            var model = mapper.Map<List<Models.ComissoesVendedores>>(list);

            return View(model);
        }
    }
}