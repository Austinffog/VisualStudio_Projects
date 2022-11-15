using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomingoADG.Models;
using DomingoADG.Respository;

namespace DomingoADG.Controllers
{
    public class JobTypeController : Controller
    {
        //Get: Get JobType/All JobType
        public ActionResult GetJobType()
        {
            JobTypeRespository JobTypeRepo = new JobTypeRespository();
            ModelState.Clear();
            return View(JobTypeRepo.GetJobType());
        }

        //Get: Get JobCards/Return JobCards
        public ActionResult CreateJobType()
        {
            return View();
        }

        // GET: JobType Update 
        public ActionResult UpdateJobType(int daily_rate)
        {
            JobTypeRespository JobTypeRepo = new JobTypeRespository();
            return View(JobTypeRepo.GetJobType().Find(DailyRate => DailyRate.daily_rate == daily_rate));
        }

        //Post: JobType Update
        [HttpPost]
        public ActionResult UpdateJobType(int dailyrate, JobTypeModel obj)
        {
            try
            {
                JobTypeRespository JobTypeRepo = new JobTypeRespository();
                JobTypeRepo.UpdateJobType(obj);

                return RedirectToAction("GetJobType");
            }
            catch
            {
                return View();
            }
        }
    }
}
