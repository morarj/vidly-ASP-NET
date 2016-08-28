﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public bool IsSuscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}