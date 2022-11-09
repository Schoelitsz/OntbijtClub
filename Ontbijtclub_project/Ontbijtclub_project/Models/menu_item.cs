using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ontbijtclub_project.Models
{
    public class menu_item
    {
        public int item_ID {get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public menu_item()
        {

        }
     
    }
}