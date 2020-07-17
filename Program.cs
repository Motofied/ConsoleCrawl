using System;
using System.IO;
using ConsoleGame.Adventures;
using ConsoleGame.Game;
using Newtonsoft.Json;

namespace ConsoleGame
{
    class Program
    {
        private static GameService gameService = new GameService();

        static void Main(string[] args)
        {

           MakeTitle();
           MakeMainMenu();

        }
        private static void MakeTitle()
    {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|      ┌─┐┌─┐┌┐┌┌─┐┌─┐┬  ┌─┐  ┌─┐┬─┐┌─┐┬ ┬┬       |");
            Console.WriteLine("|      │  │ ││││└─┐│ ││  ├┤   │  ├┬┘├─┤││││       |");
            Console.WriteLine("|      └─┘└─┘┘└┘└─┘└─┘┴─┘└─┘  └─┘┴└─┴ ┴└┴┘┴─┘     |");
            Console.WriteLine("*                                                 |");
            Console.WriteLine("---------------------------------------------------\n\n");
    
    }

   private static void MakeMainMenu()
        {
            MakeMenuOptions();
            
            var inputValid = false;

            while (!inputValid)
            {
                 
                 switch (Console.ReadLine().ToUpper())
                 {
                     case "S":
                        gameService.StartGame();
                        inputValid = true;
                        break;
                    case "C":
                        CreateCharacter();
                        inputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        inputValid = true;
                        break;

                    default:
                         Console.WriteLine("\n...Please pick an actual option...");
                        MakeMenuOptions();
                         inputValid = false;
                         break;
                 }
              
            }

        }

            private static void MakeMenuOptions()
        {
            Console.WriteLine("(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(C)reate a new character");
        }

        private static void LoadGame()

        {
            Console.WriteLine("Loading the game..");
        }

      
        
    private static void CreateCharacter() 
    {
        Console.WriteLine("You are creating a character");
    }









 }
}