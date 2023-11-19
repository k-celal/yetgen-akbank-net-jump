using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entites
{
    public class Square:Shape
    {
        public decimal OneSide { get; set; }

        public Square()
        {
            Type = "Square";
        }
        public override decimal GetArea()
        {
            return OneSide * OneSide;
        }
    }
}
