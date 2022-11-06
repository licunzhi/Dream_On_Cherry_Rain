﻿using System;
using System.Collections.Generic;

namespace EFCoreConsoleApp.ModelsScffold
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? Sex { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}