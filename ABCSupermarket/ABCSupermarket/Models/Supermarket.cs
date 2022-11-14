using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage.Table;
using System.ComponentModel.DataAnnotations;

namespace ABCSupermarket.Models
{
    public class Supermarket : TableEntity
    {
        public Supermarket() { }
        public string itemName { get; set; }
        public string itemImage { get; set; }
        public double itemPrice { get; set; }
    }
}