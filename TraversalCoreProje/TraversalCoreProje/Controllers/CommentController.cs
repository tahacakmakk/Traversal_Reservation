﻿using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using DocumentFormat.OpenXml.Drawing.Charts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;

        public CommentController( UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            //ViewBag.destID = id;
            //var value=await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = value.Id;

            return PartialView();
        }
        [HttpPost]  
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            commentManager.Tadd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
