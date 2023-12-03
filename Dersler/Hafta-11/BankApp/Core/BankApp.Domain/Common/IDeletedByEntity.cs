using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Common
{
    public interface IDeletedByEntity
    {
        public bool DeletedIs { get; set; }

        public string? DeletedByUserId { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }
    }
}
