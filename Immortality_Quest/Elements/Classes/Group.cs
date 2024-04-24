using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    internal class Group : IGroup
    {
        #region Properties / Backing Fields
        List<Entity> _members = new List<Entity>();

        public delegate void PlayerDirections(); 

        public int X { get; set; }
        public int Y { get ; set; }
        public List<Entity> Members { get => _members; set => _members = value; }

        #endregion

        #region Constructors 
        public Group()
        {

        }
        #endregion

        #region Methods 

        public void AddMember(Entity member)
        {
            Members.Add(member);
        }

        /// <summary>
        /// Gives an existing instance of an entity type, and if an entity with the same reference exisits it removes that member 
        /// </summary>
        /// <param name="member"></param>
        public void RemoveMember(Entity member)
        {
            foreach(var mem in  Members)
            {
                if(ReferenceEquals(mem, member))
                {
                    Members.Remove(mem);
                }
            }
        }

        public bool CheckGroupDead()
        {
           return Members.TrueForAll(x => x.CheckEntityDead());
        }

        public void MoveGroup(Map map)
        {
            string? userInput = null;  

            if (Y + 1 >= map.Y)
                Console.Write("N ");

            else
                Console.Write("Nx ");


            if (Y - 1 <= map.Y)
                Console.Write(" S ");
            else
                Console.Write(" Sx ");


            if (X + 1 >= map.X)
                Console.Write(" E ");
            else
                Console.Write(" Ex ");


            if (X - 1 <= map.X)

                Console.WriteLine(" W ");
            else
                Console.WriteLine(" Wx ");

            //if (Y > map.Y || Y < map.Y || X < map.X || X > map.X)
            //    Console.WriteLine("Can't go there!");

            userInput = Console.ReadLine(); 

            if (userInput == "N" || userInput == "n")
            {

            }

        }

        public bool TryMove(PlayerDirections direction) { }

        private void MoveNorth()
        {
            Y += 1;
        }

        private void MoveSouth()
        {
            Y += -1;
        }

        private void MoveWest()
        {
            X += -1;
        }
        private void MoveEast()
        {
            X += 1;
        }

        public void MoveGroup()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
