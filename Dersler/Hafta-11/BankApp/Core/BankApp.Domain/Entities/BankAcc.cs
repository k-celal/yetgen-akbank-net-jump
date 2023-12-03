﻿using BankApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entities
{
    public class BankAcc : EntityBase<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string PhoneNumber { get; set; }

        public decimal Balance { get; set; }
    }
}
