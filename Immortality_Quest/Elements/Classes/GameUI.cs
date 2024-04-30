using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public static class GameUI
    {
        #region Methods 
        public static void DisplayMovableDirections(Group plygrp, Map map)
        {
            if (plygrp.Loc.Y + 1 > map.Y)
                ColorDisplay.Write(ConsoleColor.Red, "Nx ");

            else
                ColorDisplay.Write(ConsoleColor.Green, "N ");


            if (plygrp.Loc.Y - 1 < 0)
                ColorDisplay.Write(ConsoleColor.Red, " Sx");
            else
                ColorDisplay.Write(ConsoleColor.Green, " S ");


            if (plygrp.Loc.X + 1 > map.X)
                ColorDisplay.Write(ConsoleColor.Red, " Ex ");
            else
                ColorDisplay.Write(ConsoleColor.Green, " E ");


            if (plygrp.Loc.X - 1 < 0)

                ColorDisplay.WriteLine(ConsoleColor.Red, " Wx ");
            else
                ColorDisplay.WriteLine(ConsoleColor.Green, " W ");
        }
        #endregion
    }
}
