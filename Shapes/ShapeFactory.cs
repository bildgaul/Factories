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

        public GeometricShape GetShape(ShapeType type)
        {
            switch (type){
                case ShapeType.LINE:
                    return new Line();
                case ShapeType.CIRCLE:
                    return new Circle();
                case ShapeType.RECTANGLE:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
