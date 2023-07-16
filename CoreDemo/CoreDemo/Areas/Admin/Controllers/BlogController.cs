using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace CoreDemo.Areas.Admin.Controllers
{
    //public class BlogController : Controller
    //{
    //    public IActionResult ExportStaticExcelBlogList()
    //    {
    //        using (var workbook=new XLWorkbook())
    //        {
    //            var worksheet = workbook.Worksheets.Add("Blog Listesi");
    //            worksheet.Cell(1, 1).Value = "Blog ID";
    //            worksheet.Cell(1, 2).Value = "Blog Adı";

    //            int BlogRowCount = 2;
    //            foreach (var item in GetBlogList())
    //            {
    //                worksheet.Cell(BlogRowCount, 1).Value = item.ID;
    //                worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
    //                BlogRowCount++;
    //            }
    //            using(var stream=new MemoryStream())
    //            {
    //                workbook.SaveAs(stream);
    //                var content = stream.ToArray();
    //                return File // Asp.net Core 5.0 proje kampı 95.video 14.dakikada kaldım
    //            }

    //        }
    //        return View();
    //    }
    //    List<BlogModel> GetBlogList()
    //    {
    //        List<BlogModel> bm = new List<BlogModel>
    //        {
    //            new BlogModel{ID=1,BlogName="İmdat"},
    //            new BlogModel{ID=2,BlogName="İçim Sıkılıyor"},
    //            new BlogModel{ID=3,BlogName="Bıktım artık"}
    //        };
    //        return bm;
    //    }
    //}
}
