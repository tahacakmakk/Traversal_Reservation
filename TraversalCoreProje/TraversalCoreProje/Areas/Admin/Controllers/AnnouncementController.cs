using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]

	public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetList());
            return View(values);

            //1
            //List<Announcement> announcements = _announcementService.TGetList();
            //List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            //foreach(var item in announcements)
            //{
            //    AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
            //    announcementListViewModel.ID = item.AnnouncementID;
            //    announcementListViewModel.Title = item.Title;
            //    announcementListViewModel.Content = item.Content;
            //    model.Add(announcementListViewModel);

            //}
            //return View(model);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.Tadd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                }); 
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetByID(id);
            _announcementService.TDelete(values);
			return RedirectToAction("Index");

		}

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.GetByID(id));
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Content = model.Content,
                    Title = model.Title,
					Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())

				});
				return RedirectToAction("Index");

			}
            return View(model);
		}
	}
}
