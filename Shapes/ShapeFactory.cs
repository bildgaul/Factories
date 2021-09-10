using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    enum ShapeType { Line, Circle, Rectangle, Triangle };
    class ShapeFactory
    {

        GeometricShape GetShape(ShapeType type)
        {
            return new GeometricShape(type);
        }
    }
}
