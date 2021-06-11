using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HardwareSupplier.Models
{
    public class SupplierModel
    {
        [Required(ErrorMessage = "ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

       [Required(ErrorMessage = "MobileNumber is required.")]
       [RegularExpression(@"^[0-9]{10}$",ErrorMessage="Please Enter Valid Mobile Number")]
        public string MobileNumber { get; set; }


        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pincode is required.")]
        [MaxLength(6)]
        public string Pincode { get; set; }
    }
}