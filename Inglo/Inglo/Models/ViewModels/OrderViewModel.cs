using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inglo.Models.ViewModels
{
    public class OrderViewModel
    {
        public IQueryable<string> UserID { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}