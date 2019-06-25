using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabSnapshotDebugger.Controllers
{
    public class ReproController : Controller
    {
        // GET: Repro
        public ActionResult Index()
        {
            return View();
        }

        public string ThrowException()
        {
            throw new ApplicationException("Throw Ex");
        }

        public string Return500()
        {
            Response.StatusCode = 500;
            return "500 error returned";
        }
    }
}