using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Cylinder: ICylinder
    {
        private double _radius;
        private double _height;

        public void SetHeight(double height)
        {
            if (_height > 0)
            {
                _height = height;
            }
            
                
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double Volume()
        {
            return _radius * _radius * _height * Math.PI;
        }
    }
}
