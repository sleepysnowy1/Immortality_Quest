using Immortality_Quest.Elements.Classes.Entities__Groups;
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

        public Entity GetMember(IGroupEnemy group)


        {
            string userInput = string.Empty;
            int count = 1;
            foreach (var mem in Members) //display a list of party members numbered 1 2 3 ... n
            {
                ColorDisplay.WriteLine(ConsoleColor.White, $"{count}: {mem.ToString()}");
                count++;
            }

            do
            {
                Console.WriteLine("Select Target:"); //get party member from list. 

                try
                {
                    userInput = Console.ReadLine();

                    return group.Members[Convert.ToInt32(userInput) - 1];
                }
                catch(Exception ex)
                {
                    Console.WriteLine("That doesn't work!"); 
                    userInput = string.Empty;
                }

            } while (true);

            
        }
        #endregion
    }
}
