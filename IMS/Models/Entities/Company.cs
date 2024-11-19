using System;
using System.ComponentModel.DataAnnotations;

namespace IMS.Models.Entities
{
    public class Company

    {
        [Key]
        public int CompanyId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Fax { get; set; }
        public long Phone { get; set; }
        public string Password { get; set; }
        public string Website { get; set; }

    }

}

