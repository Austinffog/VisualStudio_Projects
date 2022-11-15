using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomingoADG.Models;
using DomingoADG.Respository;

namespace DomingoADG.Controllers
{
    public class JobCardController : Controller
    {
        //Get: Get JobCards/All JobCards
        public ActionResult GetJobCards()
        {
            JobCardRespository JobRepo = new JobCardRespository();
            ModelState.Clear();
            return View(JobRepo.GetJobCards());
        }

        //Get: Get JobCards/Return JobCards
        public ActionResult CreateJobCards()
        {
            return View();
        }

        //Post: Create JobCard
        [HttpPost]
        public ActionResult CreateJobCards(JobCardModel Pat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    JobCardRespository JobRepo = new JobCardRespository();
                    if (JobRepo.CreateJobCards(Pat))
                    {
                        ViewBag.Message = "Details added successfully.";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
