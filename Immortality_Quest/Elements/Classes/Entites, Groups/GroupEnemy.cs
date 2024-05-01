using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public class GroupEnemy : IGroupEnemy
    {
        #region Properties
        public GroupType GroupType => throw new NotImplementedException();

        public List<Entity> Members { get; set; }
        #endregion

        #region Constructors 
        public GroupEnemy()
        {
            Members = new List<Entity>();
        }
        #endregion

        #region Methods
        public void AddMember(Entity member)
        {
            Members.Add(member);
        }

        public bool CheckGroupDead()
        {
            return Members.TrueForAll(x => x.CheckEntityDead());
        }

        public void RemoveMember(Entity member)
        {
            foreach (var mem in Members)
            {
                if (ReferenceEquals(mem, member))
                {
                    Members.Remove(mem);
                }
            }
        } 
        #endregion
    }
}
