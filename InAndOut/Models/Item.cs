using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;   //Add library for Key
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]   //tell data base - this is primary key  (automaticly)
        public int Id { get; set; }
        public string Borrower { get; set; }

        public string Lender { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }


    }
}
