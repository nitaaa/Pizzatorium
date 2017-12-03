using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class Ingredient
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double SmallPrice { get; set; }
        public double MediumPrice { get; set; }
        public double LargePrice { get; set; }
    }

    
}