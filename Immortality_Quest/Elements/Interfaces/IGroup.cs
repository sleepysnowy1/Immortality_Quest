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
    internal interface IGroup
    {
        public int GrpLocationX { get; set; }

        public int GrpLocationY { get; set; }

        public List<Entity> Members { get; set; }

        public void MoveGroup();
        public bool CheckGroupDead();

        public void AddMember(Entity member);
    }
}
