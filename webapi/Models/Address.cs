using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Address
    {
        [Key]
        public int Address_Id { get; set; }
        public string? ShipAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        [Required]
        [MaxLength(6)]
        [MinLength(6)]
        public string? Zip { get; set; }

    }
}