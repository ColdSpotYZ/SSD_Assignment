using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Learn_Academy.Models
{
    public class Membership
    {
        [Key]
        public string PurchaseId { get; set; }

        public System.DateTime ExpiryDate { get; set; }

        public System.DateTime Date { get; set; }

        [Range(1, 3)]
        public int Plan { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
