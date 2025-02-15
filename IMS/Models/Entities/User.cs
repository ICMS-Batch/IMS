﻿using System;
namespace IMS.Models.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool approved { get; set; }
        public Company Company { get; set; }
    }
}

