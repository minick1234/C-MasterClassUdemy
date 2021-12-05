using System;
using System.Collections.Generic;

namespace UDEMYMASTERCLASSFORCSHARP
{
    public class MyTicTacToe
    {
//TODO Tomorrow rewrite this exact program using matrix arrays instead it should be the same thing and quite easy as
//well as well think of a way to add the ai to the ai so that it actually has strategy and thinks rather than it all being a random gen value and based on chance.
//Instead of using string this could be changed to a char to be more memory efficient although its not a big deal and i would have to go and change some code to makee it work with the char.
        private static readonly string[] my2dPlayingGrid =
        {
            "1", "2", "3",
            "4", "5", "6",
            "7", "8", "9"
        };

        private static readonly string aiIcon = "O";
        private static readonly string playersIcon = "X";
        private static int totalValidPositionsLeft = my2dPlayingGrid.Length;

        public static void main(string[] args)
        {
            do
            {
                //This is the first time the grid gets drawn out for the player to see the valid postions to be able to play.
                MakePlayerMove();
                if (CheckWinConditions("LEGIT PLAYER", playersIcon)) break;
                ClearTheConsoleGrid();

                MakeAiMove();
                if (CheckWinConditions("Overpowered Ai", aiIcon)) break;
                Console.ReadLine();
                ClearTheConsoleGrid();

                //This is done after everything to see if any moves are left and if not quit the game.
                if (totalValidPositionsLeft <= 0)
                {
                    ClearTheConsoleGrid();
                    DrawOutGrid();
                    Console.WriteLine("There are no moves left to make!");
                    break;
                }

                Console.WriteLine(
                    "******************************--START OF NEW ROUND--******************************\nSPOTS AVAILABLE:{0}",
                    totalValidPositionsLeft);
            } while (totalValidPositionsLeft > 0);
        }

        //This helps to prevent the player from making a invalid move.
        private static bool DetermineIfValidMove(int attemptedMoveIndexValue)
        {
            attemptedMoveIndexValue--;
            try
            {
                if (attemptedMoveIndexValue < 0 || attemptedMoveIndexValue > my2dPlayingGrid.Length)
                    throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(
                    "The value you are trying to use is not valid. Please select a valid int value based on the points on the grid.");
                return false;
            }

            if (my2dPlayingGrid[attemptedMoveIndexValue].Contains(playersIcon))
            {
                Console.WriteLine("Cannot place another icon ontop of the players icon.");
                return false;
            }

            if (my2dPlayingGrid[attemptedMoveIndexValue].Contains(aiIcon))
            {
                Console.WriteLine("cannot place another icon ontop of the ais icon.");
                return false;
            }

            return true;
        }

        private static bool CheckWinConditions(string currentPlayersName,
            string currentPlayersBoardRepresentation)
        {
            //This checks if the first row is all covered in order for it to be a win.
            if (my2dPlayingGrid[0] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[1] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[2] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering all of row 1. The game is now over.");
                return true;
            }

            //This checks if the second row is all covered in order for it to be a win.
            if (my2dPlayingGrid[3] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[4] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[5] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering all of row 2. The game is now over.");
                return true;
            }

            //This checks if the third row is all covered for it to be a win.
            if (my2dPlayingGrid[6] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[7] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[8] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering all of row 3. The game is now over.");
                return true;
            }

            //This does all the vertical checks now for the columns to make sure that those are valid
            //Checks if the first column is matching for a win.
            if (my2dPlayingGrid[0] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[3] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[6] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering all of column 1. The game is now over.");
                return true;
            }

            //This checks if the second column is all covered in order for it to be a win.
            if (my2dPlayingGrid[1] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[4] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[7] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering all of column 2. The game is now over.");
                return true;
            }

            //This checks if the third column is all covered for it to be a win.
            if (my2dPlayingGrid[2] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[5] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[8] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering all of column 3. The game is now over.");
                return true;
            }

            //This checks for one of the diagnoals to be covered to be a diaganol win, 
            if (my2dPlayingGrid[0] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[4] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[8] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by getting a diaganol line from top left to bottom right. The game is now over.");
                return true;
            }

            //This checks for the second diaganol to be covered in order for it to be a win.
            if (my2dPlayingGrid[2] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[4] == currentPlayersBoardRepresentation &&
                my2dPlayingGrid[6] == currentPlayersBoardRepresentation)
            {
                ClearTheConsoleGrid();
                DrawOutGrid();
                Console.WriteLine(currentPlayersName +
                                  ", congrats! You won by covering the diaganol line from bottom left to the top right . The game is now over.");
                return true;
            }

            //This is incase all other cases have failed meaning there has been no win conditions.
            return false;
        }

        //This method is called anytime the grid needs to be drawn.
        private static void DrawOutGrid()
        {
            //This is what draws out the grid with the correct values each time.
            Console.WriteLine("         |         |         \n" +
                              "    {0}    |    {1}    |    {2}   \n" +
                              "         |         |         \n" +
                              "-----------------------------\n" +
                              "         |         |         \n" +
                              "    {3}    |    {4}    |    {5}   \n" +
                              "         |         |         \n" +
                              "-----------------------------\n" +
                              "         |         |         \n" +
                              "    {6}    |    {7}    |    {8}   \n" +
                              "         |         |         ",
                my2dPlayingGrid[0], my2dPlayingGrid[1], my2dPlayingGrid[2],
                my2dPlayingGrid[3], my2dPlayingGrid[4], my2dPlayingGrid[5],
                my2dPlayingGrid[6], my2dPlayingGrid[7], my2dPlayingGrid[8]);
        }

        public static void ClearTheConsoleGrid()
        {
            Console.Clear();
        }

        //This controls all of the players movements and commands.
        private static void MakePlayerMove()
        {
            //Player default move.
            var playerIndexMove = 0;
            //This makes sure that the player makes the right move and checks to see if the move is valid and wont let them continue or change the vlaue to a x until it is a valid move.
            do
            {
                DrawOutGrid();
                Console.WriteLine(
                    "What number would you like to capture...(Make sure it is a valid number and not taken!)");
                playerIndexMove = int.Parse(Console.ReadLine());
            } while (!DetermineIfValidMove(playerIndexMove));

            //The positions the player choose is now the index that i will pick
            my2dPlayingGrid[playerIndexMove - 1] = playersIcon;
            totalValidPositionsLeft--;
        }

        //TODO make the ai function with some strategies so that it can actually have a good chance of winning rather than it being completely based off chance.
        private static void MakeAiMove()
        {
            Console.WriteLine("Ai is performing its turn.....");
            var availableSpots = new List<int>();
            //As of right now this bot just picks a random spot on the grid based on the generated value.
            for (var i = 0; i < my2dPlayingGrid.Length; i++)
                if (!(my2dPlayingGrid[i].Equals(playersIcon) || my2dPlayingGrid[i].Equals(aiIcon)))
                    availableSpots.Add(i);

            //Eventually i can make it make the "best choice" based off probability so that it makes the best decision but right now if it finds another
            //o it will attempt all moves until its not possible and then it will move and attempt all other moves on other position.

            var rand = new Random();
            var aisIndexMove = rand.Next(0, availableSpots.Count);
            var aisRealPosition = availableSpots[aisIndexMove];
            my2dPlayingGrid[aisRealPosition] = aiIcon;
            DrawOutGrid();
            Console.WriteLine("The ai has selected spot number: {0}\n(Press any key to continue...)",
                aisRealPosition + 1);

            totalValidPositionsLeft--;
        }
    }
}