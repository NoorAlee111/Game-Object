using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Bl;
using GameProject.BoundaryBL;


namespace GameProject.GameObjectBL
{
    class GameObject
    {
        public char[,] shape = new char[3,3];
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public static List<GameObject> Objects = new List<GameObject>();
        public GameObject()
        {
            shape = new char[3, 3] { { '-','-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] shape, Point StartingPoint)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] shape,Point StartingPoint, Boundary Premises,string Direction)
        {
            this.shape = shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
        }
    }
}
