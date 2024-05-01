using Immortality_Quest.Elements.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Interfaces
{
    public interface IGroupEnemy
    {
        GroupType GroupType { get; }
        List<Entity> Members { get; set; }

        void AddMember(Entity member);
        bool CheckGroupDead();

        void RemoveMember(Entity member);
    }
}
