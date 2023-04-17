using Microsoft.AspNetCore.Mvc;

namespace AudioExtrato.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AudioUpload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                
                ConvertToAudio(file);
            }
            return View();
        }


        public IActionResult ConvertToAudio(HttpPostedFileBase audio)
        {
            
        }
    }
}