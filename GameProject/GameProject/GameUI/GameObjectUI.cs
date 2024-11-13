using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.GameObjectBL;
using System.Threading;

namespace GameProject.GameUI
{
    class GameObjectUI
    {
        public static void Erase()
        {
            Console.Clear();
        }
        public static void drawobject(int x)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(GameObject.Objects[x].shape[i, j]);
                }
                Console.WriteLine("");
            }
        }
        public static void MoveObjectRight()
        {

            Thread.Sleep(200);
            while (true)
            {
                if (GameObject.Objects[0].StartingPoint.y >= GameObject.Objects[0].Premises.TopRight.y)
                {
                    GameObject.Objects[0].Direction = "RightToLeft";
                    break;
                }
                if (GameObject.Objects[0].Direction == "LeftToRight")
                {
                    Erase();
                    Console.SetCursorPosition(GameObject.Objects[0].StartingPoint.y, GameObject.Objects[0].StartingPoint.x);
                    GameObject.Objects[0].StartingPoint.y = GameObject.Objects[0].StartingPoint.y + 1;
                    drawobject(0);
                }
            }
        }
        public static void MoveObjectLeft()
        {

            Thread.Sleep(200);
            while (true)
            {
                if (GameObject.Objects[1].StartingPoint.y <= GameObject.Objects[1
                    ].Premises.TopLeft.y)
                {
                    GameObject.Objects[1].Direction = "LeftToRight";
                   
                    break;
                }
                if (GameObject.Objects[1].Direction == "RightToLeft")
                {
                    Erase();
                    Console.SetCursorPosition(GameObject.Objects[1].StartingPoint.y, GameObject.Objects[1].StartingPoint.x);
                    drawobject(1);
                    GameObject.Objects[1].StartingPoint.y = GameObject.Objects[1].StartingPoint.y - 1;
                   
                }
            }
        }
    }
}
