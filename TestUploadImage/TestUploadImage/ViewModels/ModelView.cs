using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUploadImage.ViewModels
{
    public class ModelView
    {
        public string Name { get; set; }
        public HttpPostedFileBase Imagen { get; set; }
    }
}