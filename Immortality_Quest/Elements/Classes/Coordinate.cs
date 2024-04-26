using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    /// <summary>
    /// Provides storage for X and Y coordinates. Usually used to store groups' locations. 
    /// </summary>
    public struct Coordinate
    {
        #region Properties 

        private int _x; 
        private int _y;

        public int X { get => _x; set => _x = value; }

        public int Y { get => _y; set => _y = value; }

        #endregion

        #region Constructors
        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        //create an instance based on the group location. 
        public Coordinate(Group getGrpLocation)
        {
            _x = getGrpLocation.Loc.X;
            _y = getGrpLocation.Loc.Y;
        } 
        #endregion

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
        public static bool operator <=(Coordinate coord, Map map)
        {
            if (coord.X <= map.X || coord.Y <= map.Y)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >=(Coordinate coord, Map map)
        {
            if (coord.X >= map.X || coord.Y >= map.Y)
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"(X: {X}) (Y: {Y})";
        }
        #endregion
    }
}
