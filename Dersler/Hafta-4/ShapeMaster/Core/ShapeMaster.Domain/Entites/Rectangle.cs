using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entites
{
    public class Rectangle : Shape
    {
        public decimal Aside { get; set; }  
        public decimal Bside { get; set; }
        public Rectangle() 
        {
            Type = "Rectangle";
        }

        public override decimal GetArea()
        {
            return Aside * Bside;
        }
    }
}
