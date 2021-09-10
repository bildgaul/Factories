using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory s = new ShapeFactory();
            GeometricShape line = s.GetShape(ShapeType.LINE);
            try
            {
                line.Draw();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Not a line!");
            }

            GeometricShape circle = s.GetShape(ShapeType.CIRCLE);
            try
            {
                circle.Draw();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Not a circle!");
            }

            GeometricShape rectangle = s.GetShape(ShapeType.RECTANGLE);
            try
            {
                rectangle.Draw();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Not a rectangle!");
            }

            GeometricShape triangle = s.GetShape(ShapeType.TRIANGLE);
            try
            {
                triangle.Draw();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Not a triangle!");
            }

            
        }
    }
}
