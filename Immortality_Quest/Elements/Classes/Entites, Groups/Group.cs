using Immortality_Quest.Elements.Classes.Inventory_and_items;
using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Immortality_Quest.Elements.Classes
{
    public class Group : IGroup
    {
        #region Properties / Backing Fields
        List<Entity> _members = new List<Entity>();

        

        public Coordinate Loc; 

        public delegate Coordinate Directions();

        private readonly GroupType grpType;

        public GroupType GroupType { get;  }

        public Inventory groupInventory; 


        public List<Entity> Members { get => _members; set => _members = value; }

        #endregion

        #region Events
        
        #endregion

        #region Constructors 

        public Group()
        {
            Loc = new Coordinate();
            Loc.X = 0; 
            Loc.Y = 0;
            Members.Add(new Player()); 
            groupInventory = new Inventory();
            GroupType = GroupType.Friendly; 
            
        }
        public Group(int x, int y)
        {
            Loc = new Coordinate();
            groupInventory = new Inventory();
            Loc.X = x;
            Loc.Y = y;             
        }
        #endregion

        #region Methods 
        public Tiles GetTileAtCurrentLoc(GameManager game)
        {
            return game.gameMap.TryGetTile(Loc.X, Loc.Y ); 
        }
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


        public Coordinate MoveNorth()
        {
            Coordinate coord = new Coordinate(this);
            coord.Y += 1;
            return coord;
        }

        public Coordinate MoveSouth()
        {
            Coordinate coord = new Coordinate(this);
            coord.Y += -1;
            return coord;
        }

        public Coordinate MoveWest()
        {
            Coordinate coord = new Coordinate(this);
            coord.X += -1;
            return coord;
        }
        public Coordinate MoveEast()
        {
            Coordinate coord = new Coordinate(this);
            coord.X += 1;
        
        return coord;
        }

        /// <summary>
        /// Shows the user a list of group memebers and asks them to pick 1 from the list. 
        /// </summary>
        /// <param name="game"></param>
        /// <returns>Returns selected party name.</returns>
        public Entity GetMember(GameManager game)
            
            
        {
            string userInput = string.Empty;
            int count = 1; 
            foreach (var mem in Members) //display a list of party members numbered 1 2 3 ... n
            {
                ColorDisplay.WriteLine(ConsoleColor.White, $"{count}: {mem.ToString()}" );
                count++;
            }

            do
            {
                
            Console.WriteLine("Select Group Member:"); //get party member from list. 
                try
                {
                    userInput = Console.ReadLine();

                    return game.PlyrGrp.Members[Convert.ToInt32(userInput) - 1];
                }
                catch (Exception ex)
                {

                    Console.WriteLine("that doesn't work!");
                    userInput = string.Empty;
                } 

            } while (true);

            
            
        }



        #endregion
    }

    public enum GroupType
    {
        Neutral, 
        Hostile,
        Friendly
    }
}
