using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    enum ShapeType { LINE, CIRCLE, RECTANGLE, TRIANGLE };
    class ShapeFactory
    {

        GeometricShape GetShape(ShapeType type)
        {
            GeometricShape shape;
            if (type == ShapeType.LINE)
            {
                shape = new Line();
            }
            else
            {
                shape = null;
            }
            return shape;
        }
    }
}
