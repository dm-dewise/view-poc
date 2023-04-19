﻿using System.ComponentModel.DataAnnotations;

namespace user.domain
{
    public class Address
    {
        public Guid Id { get; set; }        
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set;}
        public string State { get; set;}
        public string PostalCode { get; set;}
        public string Country { get; set; }
    }
}
