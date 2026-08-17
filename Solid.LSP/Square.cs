using Solid.LSP.Interface;

namespace Solid.LSP
{
    public class Square : Rectangle
    {
        public override int Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override int Height
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }

    public class Square2 : IShape
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }
}
