﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyExampleMVC.Entities
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int Id { get; set; } // abstract property


        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string GroupName { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public DateTime Birthday { get; set; }




    }
}
	

