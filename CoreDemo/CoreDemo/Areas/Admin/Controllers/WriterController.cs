using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var JsonWriter = JsonConvert.SerializeObject(writers);
            return Json(JsonWriter);
        }

        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter = writers.FirstOrDefault(x => x.ID == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);

        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                ID=1,
                Name="Ayşe"
            },
            new WriterClass
            {
                ID=2,
                Name="Ahmet"
            },
            new WriterClass
            {
                ID=3,
                Name="Buse"
            },

        };
    }
}
