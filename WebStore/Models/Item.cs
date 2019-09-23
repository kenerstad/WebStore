using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Item
    {

        public int id { get; set; }

        [Required, StringLength(60)]
        public string name { get; set; }

        [Required, StringLength(30)]
        public string type { get; set; }
    }
}
