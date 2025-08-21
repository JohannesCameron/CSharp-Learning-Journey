using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            list.Add(new Shape());
            list.Add(new Circle());
            list.Add(new Rectangle());
            list.Add(new Triangle());

            foreach (Shape shape in list)
            {
                shape.Draw();
            }
        }
    }
}
