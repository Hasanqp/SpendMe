﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpendMe.Core
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
