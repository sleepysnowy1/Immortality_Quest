using Immortality_Quest.Elements.Classes;
using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Interfaces
{
    public interface IGroup 
    {
        GroupType GroupType { get; }
        List<Entity> Members { get; set; }

        
        void AddMember(Entity member);
        bool CheckGroupDead();
        Entity GetMember(GameManager game);
        Tiles GetTileAtCurrentLoc(GameManager game);
        Coordinate MoveEast();
        Coordinate MoveNorth();
        Coordinate MoveSouth();
        Coordinate MoveWest();
        void RemoveMember(Entity member);
    }
}
