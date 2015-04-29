using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUploadImage.ViewModels;

namespace TestUploadImage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            return View(new ModelView());
        }

        [HttpPost]
        public ActionResult Guardar(ModelView model)
        {
            {
                var file = model.Imagen;
                // Verify that the user selected a file
                if (file != null && file.ContentLength > 0)
                {
                    // extract only the fielname
                    var fileName = Path.GetFileName(file.FileName);
                    // store the file inside ~/App_Data/uploads folder
                    var path = Path.Combine(Server.MapPath("~/App_Data"), fileName);
                    file.SaveAs(path);
                }
                // redirect back to the index action to show the form once again
                return RedirectToAction("Index");
            }
        }

    }
}
