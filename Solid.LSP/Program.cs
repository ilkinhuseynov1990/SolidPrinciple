using System;


namespace Solid.LSP
{
    internal class Program
    {
        // Duzbucaqlida bir problem yaratmayacaq.
        // amma isin icine Kvadrat girdikde Problem olacaq.
        static void PrintArea(Rectangle rectangle)
        {
            rectangle.Width = 5;
            rectangle.Height = 4;

            Console.WriteLine($"Area: {rectangle.Area()}");
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();

            PrintArea(rectangle);


            Rectangle rectangle1 = new Rectangle();

            PrintArea(rectangle1);
        }
    }
}
