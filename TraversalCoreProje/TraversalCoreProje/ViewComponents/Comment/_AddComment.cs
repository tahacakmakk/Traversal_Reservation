﻿using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(EntityLayer.Concrete.Comment p)
        //{
        //    p.CommentDate =Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.CommentState = true;
        //    commentManager.Tadd(p);
        //    return View();
        //}
    }
}
