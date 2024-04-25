using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public struct Coordinate
    {
        #region Properties 

        private int _x; 
        private int _y;

        public int X { get => _x; set => _x = value; }

        public int Y { get => _y; set => _y = value; }

        #endregion

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coordinate(Group getGrpLocation)
        {
            _x = getGrpLocation.X;
            _y = getGrpLocation.Y;
        }

        #region Operator overloads
        public static bool operator <(Coordinate coord, Map map)
        {
            if(coord.X < map.X || coord.Y < map.Y)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >(Coordinate coord, Map map)
        {
            if(coord.X > map.X || coord.Y > map.Y)
            {
                return true;
            }
            else
                return false;
        }
        #endregion
    }
}
