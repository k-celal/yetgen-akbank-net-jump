using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entites
{
    public class Triangle : Shape
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }
        public Triangle() { 
            Type="Triangle"
        }   
        public decimal GetArea()
        {
            return (Base * Height) / 2;
        }

        public override decimal GetArea()
        {
            return (Base * Height) / 2;
        }
    }
}
