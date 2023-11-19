﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10Ders.Domain.Entities
{
    public interface ICreatedByEntity
    {
        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}