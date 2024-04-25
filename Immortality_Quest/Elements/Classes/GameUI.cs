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
                Console.Write("Nx ");

            else
                Console.Write("N ");


            if (plygrp.Loc.Y - 1 < 0)
                Console.Write(" Sx");
            else
                Console.Write(" S ");


            if (plygrp.Loc.X + 1 > map.X)
                Console.Write(" Ex ");
            else
                Console.Write(" E ");


            if (plygrp.Loc.X - 1 < 0)

                Console.WriteLine(" Wx ");
            else
                Console.WriteLine(" W ");
        }
        #endregion
    }
}
