using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccsessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
	public class ExcelController : Controller
	{
		private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
		{
			return View();
		}
		public List<DestinationModel> DestinationList() 
		{
			List<DestinationModel> destinationModels = new List<DestinationModel>();
			using(var c = new Context())
			{
				destinationModels = c.Destinations.Select(x => new DestinationModel
				{
					City = x.City,
					DayNight = x.DayNight,	
					Price = x.Price,	
					Capacity = x.Capacity
				}).ToList();
			}
			return destinationModels;
		}
		public IActionResult StaticExcelReport()
		{
			return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlfortmats-officedocument.spreadsheetml.sheet", "yeniexcel.xlsx");

			//ExcelPackage excel = new ExcelPackage();
			//var workSheet = excel.Workbook.Worksheets.Add("Sayfa 1");
			//workSheet.Cells[1, 1].Value = "Rota";
			//workSheet.Cells[1, 2].Value = "Rehber";
			//workSheet.Cells[1, 3].Value = "Kontenjan";

			//workSheet.Cells[2, 1].Value = "Gürcüstan Batum";
			//workSheet.Cells[2, 2].Value = "Kadir Yıldız";
			//workSheet.Cells[2, 3].Value = "50";


			//workSheet.Cells[3, 1].Value = "Sırbistan - Makadenyo";
			//workSheet.Cells[3, 2].Value = "Zeynep Öztürk";
			//workSheet.Cells[3, 3].Value = "35";

			//var bytes = excel.GetAsByteArray();

			//return File(bytes, "application/vnd.openxmlfortmats-officedocument.spreadsheetml.sheet", "dosya2.xlsx");
		}

		public IActionResult DestinationExcelReport()
		{
			using (var workBook = new XLWorkbook())
			{
				var workSheet = workBook.Worksheets.Add("Tur Listesi");
				workSheet.Cell(1, 1).Value = "Şehir";
				workSheet.Cell(1, 2).Value = "Konaklama Süresi";
				workSheet.Cell(1, 3).Value = "Fiyat";
				workSheet.Cell(1, 4).Value = "Kapasite";

				int rowCont = 2;
				foreach(var item in DestinationList())
				{
					workSheet.Cell(rowCont,1).Value = item.City;
					workSheet.Cell(rowCont,2).Value = item.DayNight;
					workSheet.Cell(rowCont,3).Value = item.Price;
					workSheet.Cell(rowCont,4).Value = item.Capacity;
					rowCont++;
				}
				using (var stream = new MemoryStream())
				{
					workBook.SaveAs(stream);
					var content = stream.ToArray();
					return File(content, "application/vnd.openxmlfortmats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
				}
			}
		}
	}
}
