using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CityController : Controller
	{
		private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
		{
			return View();
		}
		public IActionResult CityList()
		{
			var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
			return Json(jsonCity);
		}
		[HttpPost]
		public IActionResult AddCityDestination(Destination d)
		{
			d.Status = true;
			_destinationService.Tadd(d);
			var values =JsonConvert.SerializeObject(d);
			return Json(values);
		}

		public IActionResult GetById(int DestinationID)
		{
			var values = _destinationService.GetByID(DestinationID);
			var jsonValues = JsonConvert.SerializeObject(values);
			return Json(jsonValues);
		}

		public IActionResult DeleteCity(int id)
		{
			var values = _destinationService.GetByID(id);
			_destinationService.TDelete(values);
			return NoContent();
		}

		public IActionResult UpdateCity(Destination destination)
		{
			_destinationService.TUpdate(destination);
			var valuesCustom = JsonConvert.SerializeObject(destination);
			return Json(valuesCustom);
		}
		public static List<CityClass> cities = new List<CityClass>
		{
			new CityClass()
			{
				CityID =1,
				CityName="Üsküp",
				CityCountry="Makedonya"

			},
			new CityClass()
			{
				CityID=2,
				CityName="Roma",
				CityCountry="İtalya"
			},
			new CityClass()
			{
				CityID=3,
				CityName="Londra",
				CityCountry="İngiltere"
			}

		};


    }
}
