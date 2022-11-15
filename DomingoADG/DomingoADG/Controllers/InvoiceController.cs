using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomingoADG.Models;
using DomingoADG.Respository;

namespace DomingoADG.Controllers
{
    public class InvoiceController : Controller
    {
        //Get: Get Invoice/All Invoice
        public ActionResult GetInvoice()
        {
            InvoiceRespository InvoiceRepo = new InvoiceRespository();
            ModelState.Clear();
            return View(InvoiceRepo.GetInvoice());
        }

        //Get: Get Invoice/Return Invoice
        public ActionResult CreateInvoice()
        {
            return View();
        }

        //Post: Create Invoice
        [HttpPost]
        public ActionResult CreateInvoice(InvoiceModel inv)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    InvoiceRespository InvoiceRepo = new InvoiceRespository();
                    if (InvoiceRepo.CreateInvoice(inv))
                    {
                        ViewBag.Mess = "Details added successfully.";
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
