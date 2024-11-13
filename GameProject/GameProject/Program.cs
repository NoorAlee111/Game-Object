using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameProject.BoundaryBL;
using GameProject.Bl;
using GameProject.GameObjectBL;
using GameProject.GameObjectDl;
using System.Threading;
using GameProject.GameUI;

namespace GameProject
{
    class Program
    {
        public static char[,] triangle = new char[3, 3] { {'*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };
        public static char[,] triangle2 = new char[3, 3] { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };
        public static Point P = new Point(0, 0);
        public static Boundary B = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
        public static Point P2 = new Point(0, 90);
        public static Boundary B2= new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
        static void Main(string[] args)
        {
            Thread.Sleep(200);
            GameObject NewObject = new GameObject(triangle, P, B, "LeftToRight");
            GameObject NewObject2 = new GameObject(triangle2, P2, B2, "RightToLeft");
            GameObjectDL.AddObjectIntoList(NewObject);
            GameObjectDL.AddObjectIntoList(NewObject2);
            GameObjectUI.Erase();
           // GameObjectUI.MoveObjectRight();
            GameObjectUI.MoveObjectLeft();
            Console.ReadKey();

        }
    }
}
