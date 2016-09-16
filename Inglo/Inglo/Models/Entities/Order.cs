using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inglo.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public int ProductID { get; set; }
    }
}