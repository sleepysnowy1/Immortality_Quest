using Immortality_Quest.Elements.Classes;
using Immortality_Quest.Elements.Classes.Inventory_and_items;
using Immortality_Quest.Elements.Interfaces;

namespace Immortality_Quest;

class Program
{
    static void Main(string[] args)
    {

        //map generation and other stuff
       GameManager game = new GameManager();

        game.gameMap.GenerateMap();

        //intialize game combat mechanics 
        GameCombat gameCombat = new GameCombat(game);


        

        game.PlyrGrp.Members[0].equipped.equipedWeapon = new Sword();

        




        string userInput = string.Empty;
        do
        {
            

            do
            {
                game.gameMap.PrintMap(game);

                GameUI.DisplayMovableDirections(game.PlyrGrp, game.gameMap);
                game.ShowActions(game); 

                Console.WriteLine(game.PlyrGrp.Loc.ToString());
                
                
                Console.Clear(); 
            } while (true);
        }while(true);   



        
    }
}
