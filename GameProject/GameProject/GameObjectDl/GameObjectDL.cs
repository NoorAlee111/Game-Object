using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.BoundaryBL;
using GameProject.Bl;
using GameProject.GameObjectBL;

namespace GameProject.GameObjectDl
{
    class GameObjectDL
    {
        public static void AddObjectIntoList(GameObject NewObject)
        {
            GameObject.Objects.Add(NewObject);
        }
    }

}
