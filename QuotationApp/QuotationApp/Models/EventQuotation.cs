using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuotationApp.Models
{
    public class EventQuotation
    {

        public int Id { get; set; }

        public string Type { get; set; }

        public string Tematic { get; set; }

        [Display(Name = "Number of people")]
        public int NumberOfPeople { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Hour")]
        [DataType(DataType.Time)]
        public DateTime hour { get; set; }
        
        public string Colors { get; set; }

        [Display(Name = "Full Package?")]
        public Boolean FullPackage { get; set; }

        public string Details { get; set; }
    }
}
