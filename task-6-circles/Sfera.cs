using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Sfera : ISfera
    {
        private double _radius;

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double Volume()
        {
            return 4 / 3 * Math.PI * _radius * _radius * _radius;
        }
    }
}
