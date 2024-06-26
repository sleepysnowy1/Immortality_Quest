﻿using Immortality_Quest.Elements.Classes.Entities__Groups;
using Immortality_Quest.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Immortality_Quest.Elements.Classes
{
    public class GameCombat
    {
        #region Constructors 
        public GameCombat(GameManager game)
        {
            game.PlayerMoved += OnPlayerMoved;
        }
        #endregion

        #region Methods 
        /// <summary>
        /// Checks the tile for forced encounters with enemies
        /// </summary>
        public void OnPlayerMoved(Coordinate playerLocation, GameManager game)
        {
            if (game.gameMap.Level[playerLocation.X, playerLocation.Y].Enemies.Members.Count > 0)
            {
                IGroupEnemy enemies = game.gameMap.Level[playerLocation.X, playerLocation.Y].Enemies;
                BeginCombat(game, enemies); 
            }
        }

        public void BeginCombat(GameManager game, IGroupEnemy Enemies)
        {
            bool turnOver = false;
            string userInput = string.Empty;
            Entity target; 
            Random rnd = new Random();
            
            ColorDisplay.WriteLine(ConsoleColor.Red, "Danger!", ConsoleColor.White, "Combat is about to commence!");
            Console.ReadLine();

            while(game.PlyrGrp.CheckGroupDead() == false && game.PlyrGrp.GetTileAtCurrentLoc(game).Enemies.CheckGroupDead() == false)
            {

                //combat time
                do
                {
                    PrintBattleStatus(game.PlyrGrp, Enemies);
                    userInput = Console.ReadLine();
                    //players turn 
                    switch (userInput)
                    {
                        case "Attack": case "attack": case "A": case "a":
                            game.PlyrGrp.GetMember(game).Attack(Enemies.GetMember(Enemies));
                            turnOver = true;
                            break;
                    }

                } while (turnOver == false);

                Enemies.Members[0].Attack(game.PlyrGrp.Members[0]);
            }

            if(game.PlyrGrp.CheckGroupDead() == true)
            {
                ColorDisplay.WriteLine(ConsoleColor.Red, "You have perished.");
                Environment.Exit(0);
                Console.Beep();
            }
            else
            {
                ColorDisplay.WriteLine(ConsoleColor.Green, "You obtained victory!!!");
                Console.Beep();
                Console.ReadLine(); 
            }

            //foreach(var enemy in Enemies.Members) //TODO add looting of enemies
            //{
            //    game.PlyrGrp.groupInventory.items.Add(enemy.equipped.equipedWeapon);
            //    ColorDisplay.WriteLine(ConsoleColor.White, "You looted", ConsoleColor.Blue, $"{enemy.equipped.equipedWeapon.ItemName}");
            //}

            Console.ReadLine() ;

        }

        private void PrintBattleStatus(IGroup group1, IGroupEnemy group2)
        {
            int count = 1; 
            foreach(var member in group1.Members)
            {
                member.CheckEntityStatus(count);
                count++; 
            }

            count = 1;
            foreach (var member in group2.Members)
            {
                member.CheckEntityStatus(count);
                count++;
            }

            ColorDisplay.Write(ConsoleColor.Green, "A", ConsoleColor.White, "ttack\n"); 
        }
        #endregion
    }
}
