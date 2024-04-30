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

        


        //test stuff goes here
        //BreastPlate breast = new BreastPlate();
        //Sword sword = new Sword();

        //Console.WriteLine(breast.ToString());
        //Console.WriteLine(sword.ToString());

        //game.PlyrGrp.groupInventory.AddItem(sword); 

        //game.PlyrGrp.groupInventory.AddItem(breast);

        //game.PlyrGrp.groupInventory.ShowInventory(); 


        

        string userInput = string.Empty;
        do
        {
            

            do
            {
                game.gameMap.PrintMap();

                GameUI.DisplayMovableDirections(game.PlyrGrp, game.gameMap);
                game.ShowActions(game); 

                Console.WriteLine(game.PlyrGrp.Loc.ToString());
                
                
                Console.Clear(); 
            } while (true);
        }while(true);   



        
    }
}
