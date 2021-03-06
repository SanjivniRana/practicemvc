﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace practicemvc.Models
{
    public class dbase
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberType MemberType { get; set; }
        [Display(Name = "Membership Type ")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}