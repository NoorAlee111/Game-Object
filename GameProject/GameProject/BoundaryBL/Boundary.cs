using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Bl;
using GameProject.GameObjectBL;

namespace GameProject.BoundaryBL
{
    class Boundary
    {
        public Point TopLeft;
        public Point TopRight;
        public Point BottomLeft;
        public Point BottomRight;
        public Boundary()
        {
            TopLeft.x=0;
            TopLeft.y = 0;
            TopRight.x = 0;
            TopRight.y = 90;
            BottomLeft.x = 90;
            BottomLeft.y=0;
            BottomRight.x = 90;
            BottomRight.y = 90;
        }
        public Boundary(Point TopLeft,Point TopRight,Point BottomLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this. BottomLeft=  BottomLeft;
            this.BottomRight = BottomRight;
        }
    }
}
