using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace example.Entities
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string Designation { get; set; }

      

    }
}
