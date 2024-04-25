﻿using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public class Group 
    {
        #region Properties / Backing Fields
        List<Entity> _members = new List<Entity>();

        public Coordinate Loc; 

        public delegate Coordinate Directions(); 

        
        public List<Entity> Members { get => _members; set => _members = value; }

        #endregion

        #region Constructors 

        public Group()
        {
            Loc = new Coordinate();
            Loc.X = 0; 
            Loc.Y = 0;
            Members.Add(new Player()); 
        }
        public Group(int x, int y)
        {
            Loc = new Coordinate();
            Loc.X = x;
            Loc.Y = y;             
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

        /// <summary>
        /// Provides the logic for whether a group can move in a specified direction
        /// </summary>
        /// <param name="map"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool TryMoveGroup(Map map, Directions direction )
        {
            
            //TODO: move this to another class, this serves as a display provides no value to the purpose of the method
            

            //determine whether the player can move in the specified direction 


            return false;

            


        }

        //public bool TryMove(PlayerDirections direction) { }

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
            Loc.X += -1;
            return coord;
        }
        public Coordinate MoveEast()
        {
            Coordinate coord = new Coordinate(this);
            coord.X += 1;
        
        return coord;
        }

        




        #endregion
    }
}