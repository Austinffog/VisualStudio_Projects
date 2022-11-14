using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABCSupermarket.Models;
using ABCSupermarket.TableHandler;
using ABCSupermarket.BlobHandler;

namespace ABCSupermarket.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            //for our edit
            if (!string.IsNullOrEmpty(id))
            {
                //set the name of the table
                TableManager TableManagerObj = new TableManager("Item");
                //retrieve the car to be updated
                List<Supermarket> SupermarketListObj = TableManagerObj.RetrieveEntity<Supermarket>("RowKey eq '" + id + "'");

                Supermarket SupermarketObj = SupermarketListObj.FirstOrDefault();
                return View(SupermarketObj);
            }
            return View(new Supermarket());
        }
        // GET: Home
        [HttpPost]
        public ActionResult Index(string id, HttpPostedFileBase uploadFile, FormCollection formData)
        {
            Supermarket SupermarketObj = new Supermarket();
            SupermarketObj.itemName = formData["itemName"] == "" ? null : formData["itemName"];
            double itemPrice;
            if (double.TryParse(formData["itemPrice"], out itemPrice))
            {
                SupermarketObj.itemPrice = double.Parse(formData["itemPrice"] == "" ? null : formData["itemPrice"]);
            }
            else
            {
                return View(new Supermarket());
            }
            foreach (string file in Request.Files)
            {
                uploadFile = Request.Files[file];
            }
            //blob container creation
            BlobManager BlobManagerObj = new BlobManager("pictures");
            string FileAbsoluteUri = BlobManagerObj.UploadFile(uploadFile);
            SupermarketObj.itemImage = FileAbsoluteUri.ToString();
            //Insert statement
            if (string.IsNullOrEmpty(id))
            {
                SupermarketObj.PartitionKey = "Item";
                SupermarketObj.RowKey = Guid.NewGuid().ToString();
                TableManager TableManagerObj = new TableManager("Item");
                TableManagerObj.InsertEntity<Supermarket>(SupermarketObj, true);
            }
            else
            {
                SupermarketObj.PartitionKey = "Item";
                SupermarketObj.RowKey = id;
                TableManager TableManagerObj = new TableManager("Item");
                TableManagerObj.InsertEntity<Supermarket>(SupermarketObj, false);
            }
            return RedirectToAction("Get");
        }
        //get items
        public ActionResult Get()
        {
            TableManager TableManagerObj = new TableManager("Item");
            List<Supermarket> SupermarketListObj = TableManagerObj.RetrieveEntity<Supermarket>(null);
            return View(SupermarketListObj);
        }
        //Delete items
        public ActionResult Delete(string id)
        {
            //return the item to be deleted
            TableManager TableManagerObj = new TableManager("Item");
            List<Supermarket> SupermarketListObj = TableManagerObj.RetrieveEntity<Supermarket>("RowKey eq'" + id + "'");

            Supermarket SupermarketObj = SupermarketListObj.FirstOrDefault();
            //delete the item
            TableManagerObj.DeleteEntity<Supermarket>(SupermarketObj);
            return RedirectToAction("Get");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";
            return View();
        }
    }
}