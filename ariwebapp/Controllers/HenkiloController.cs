using ariwebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ariwebapp.Controllers
{
    public class HenkiloController : Controller
    {
        // GET: Henkilo
        public ActionResult Index()
        {
            arisqlEntities2 entities = new arisqlEntities2();
            List<Henkilot> model = entities.Henkilots.ToList();
            entities.Dispose();
            
            return View(model);
        }
        public ActionResult HaeTunnit(string id)
        {
            int apuiidee;
            apuiidee = int.Parse(id);

           arisqlEntities2 entities = new arisqlEntities2();
            List<Tunnit> tunnit = (from t in entities.Tunnits
                                   where t.Henkilo_id == apuiidee
                                   select t).ToList();
            entities.Dispose();

           // return Json(tunnit, JsonRequestBehavior.AllowGet);

            List<tuntilista> result = new List<tuntilista>();
            foreach (Tunnit tunti in tunnit)
            {
                tuntilista data = new tuntilista();
                data.Projekti_id = id;
                data.Tunnit = "33";
                result.Add(data);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        
            //return View(result);
        }


    }
}