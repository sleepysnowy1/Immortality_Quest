using Immortality_Quest.Elements.Classes;
using Immortality_Quest.Elements.Interfaces;

namespace Immortality_Quest;

class Program
{
    static void Main(string[] args)
    {
       GameManager game = new GameManager();

        game.gameMap.GenerateMap(); 

        

        

        string userInput = string.Empty;
        do
        {
            

            do
            {
                game.gameMap.PrintMap();

                GameUI.DisplayMovableDirections(game.PlyrGrp, game.gameMap);

                Console.WriteLine(game.PlyrGrp.Loc.ToString());
                userInput = Console.ReadLine();
                
                Console.Clear(); 
            } while (game.TryMove(GameUtility.GetDirection(userInput, game.PlyrGrp)) == false);
        }while(true);   



        
    }
}
