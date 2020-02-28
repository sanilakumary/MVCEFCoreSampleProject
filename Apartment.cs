using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApartmentAdministrationNew.Models
{
    public class Apartment
    {
        public int ID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [StringLength(255, MinimumLength = 3)]        
        [Required]
        public string Street { get; set; }
        [RegularExpression(@"^(?!01000|99999)(0[1-9]\d{3}|[1-9]\d{4})$")]
        [DataType(DataType.PostalCode)]
        [Required]
        public int Zipcode { get; set; }
        [StringLength(255, MinimumLength = 3)]
        [Required]
        public string City { get; set; }
        [Required]
        public bool  IsInActive { get; set; }

      
    }
}
