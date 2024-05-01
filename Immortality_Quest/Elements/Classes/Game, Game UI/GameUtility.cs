using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public static class GameUtility
    {
        #region Methods 
        public static Group.Directions GetDirection(string userInput, Group plygrp)
        {
            switch (userInput)
            {
                case "N": case "n":
                    return plygrp.MoveNorth;

                case "S": case "s":
                    return plygrp.MoveSouth;

                case "W": case "w": 
                    return plygrp.MoveWest;

                case "E": case "e": 
                    return plygrp.MoveEast;

                default: 
                    throw new NotImplementedException(); //TODO: figure out what to do when wrong input is inserted
            }
        }
        #endregion
    }
}
