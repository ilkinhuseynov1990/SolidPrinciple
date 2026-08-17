using Solid.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    public  class Rectangle 
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }
    }


    public class Rectangle2 : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }
}
