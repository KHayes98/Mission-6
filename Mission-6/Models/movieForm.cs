using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public short year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }
        public string notes { get; set; }


    }
}
