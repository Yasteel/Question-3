using System;

namespace Question3
{
    class TicTacToe
    {
        private string[,] board = new string[3, 3];
        private string xOrO = "";
        public bool play = true;
        public int turn = 0;

        public void emptyBoard()
        {
            board[0, 0] = "[A]";
            board[0, 1] = "[B]";
            board[0, 2] = "[C]";

            board[1, 0] = "[D]";
            board[1, 1] = "[E]";
            board[1, 2] = "[F]";

            board[2, 0] = "[G]";
            board[2, 1] = "[H]";
            board[2, 2] = "[I]";
        }

        public void displayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", board[i, j]);
                }
                Console.Write("\n");
            }
        }

        public void setXorO()
        {
            if (turn == 0)
            {
                xOrO = "X";
            }
            else if (turn == 1)
            {
                xOrO = "O";
            }
        }

        public void endGame()
        {
            play = false;
        }

        public void changeTurn()
        {
            if (turn == 0)
            {
                turn = 1;
            }
            else
            {
                turn = 0;
            }
        }

        public void checkMove(String block, int turn)
        {

            if (block == "A")
            {
                if (board[0, 0] != "X" || board[0, 0] != "O")
                {
                    board[0, 0] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "B")
            {
                if (board[0, 1] != "X" || board[0, 1] != "O")
                {
                    board[0, 1] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "C")
            {
                if (board[0, 2] != "X" || board[0, 2] != "O")
                {
                    board[0, 2] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "D")
            {
                if (board[1, 0] != "X" || board[1, 0] != "O")
                {
                    board[1, 0] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "E")
            {
                if (board[1, 1] != "X" || board[1, 1] != "O")
                {
                    board[1, 1] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "F")
            {
                if (board[1, 2] != "X" || board[1, 2] != "O")
                {
                    board[1, 2] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "G")
            {
                if (board[2, 0] != "X" || board[2, 0] != "O")
                {
                    board[2, 0] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else if (block == "H")
            {
                if (board[2, 1] != "X" || board[2, 1] != "O")
                {
                    board[2, 1] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                }
            }
            else if (block == "I")
            {
                if (board[2, 2] != "X" || board[2, 2] != "O")
                {
                    board[2, 2] = xOrO;
                }
                else
                {
                    Console.WriteLine("\nThat block has already been taken");
                    changeTurn();
                }
            }
            else
            {
                Console.WriteLine("\nInvalid move!");
                changeTurn();
            }

            displayBoard();
        }

        public void checkWinner()
        {
            String player = "";
            int count = 0;

            if (turn == 0)
            {
                player = "Player 2";
            }
            else
            {
                player = "Player 1";
            }

            if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X" || board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }
            else if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X" || board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }
            else if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X" || board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }
            else if (board[0, 0] == "X" && board[1, 0] == "X" && board[2, 0] == "X" || board[0, 0] == "O" && board[1, 0] == "O" && board[2, 0] == "O")
            {

                Console.WriteLine(player + " wins");
            }
            else if (board[0, 1] == "X" && board[1, 1] == "X" && board[2, 1] == "X" || board[0, 1] == "O" && board[1, 1] == "O" && board[2, 1] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }
            else if (board[0, 2] == "X" && board[1, 2] == "X" && board[2, 2] == "X" || board[0, 2] == "O" && board[1, 2] == "O" && board[2, 2] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }
            else if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X" || board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }
            else if (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X" || board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O")
            {
                Console.WriteLine(player + " wins");
                endGame();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "X" || board[i, j] == "O")
                    {
                        count++;
                    }
                }
            }

            if (count == 9)
            {
                Console.WriteLine("\nDraw!");
                endGame();
            }
        }

    }

    class Program
    {
            //String[,] board = new String[4, 4];
            //String[] letters = new String[] { "A", "B", "C" };
            //String xOrO = "";
            //Boolean play = true;
            //int turn = 0;

            //public void emptyBoard()
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            board[i, j] = "[ ]";
            //        }
            //    }

            //    board[0, 0] = "";
            //}

            //public void displayBoard()
            //{
            //    for (int c = 1; c < 4; c++)
            //    {
            //        board[0, c] = "" + c;
            //    }

            //    for (int r = 0; r < 3; r++)
            //    {
            //        board[r + 1, 0] = "" + letters[r];
            //    }

            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write(board[i, j] + "\t");
            //        }
            //        Console.Write("\n");
            //    }
            //}

            //public void setXorO()
            //{
            //    if (turn == 0)
            //    {
            //        xOrO = "X";
            //    }
            //    else if (turn == 1)
            //    {
            //        xOrO = "O";
            //    }
            //}

            //public void endGame()
            //{
            //    play = false;
            //}

            //public void changeTurn()
            //{
            //    if (turn == 0)
            //    {
            //        turn = 1;
            //    }
            //    else
            //    {
            //        turn = 0;
            //    }
            //}

            //public void checkMove(String block, int turn)
            //{

            //    if (block == "A1" || block == "a1")
            //    {
            //        if (board[1, 1] == "[ ]")
            //        {
            //            board[1, 1] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "A2" || block == "a2")
            //    {
            //        if (board[1, 2] == "[ ]")
            //        {
            //            board[1, 2] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "A3" || block == "a3")
            //    {
            //        if (board[1, 3] == "[ ]")
            //        {
            //            board[1, 3] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "B1" || block == "b1")
            //    {
            //        if (board[2, 1] == "[ ]")
            //        {
            //            board[2, 1] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "B2" || block == "b2")
            //    {
            //        if (board[2, 2] == "[ ]")
            //        {
            //            board[2, 2] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "B3" || block == "b3")
            //    {
            //        if (board[2, 3] == "[ ]")
            //        {
            //            board[2, 3] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "C1" || block == "c1")
            //    {
            //        if (board[3, 1] == "[ ]")
            //        {
            //            board[3, 1] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else if (block == "C2" || block == "c2")
            //    {
            //        if (board[3, 2] == "[ ]")
            //        {
            //            board[3, 2] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //        }
            //    }
            //    else if (block == "C3" || block == "c3")
            //    {
            //        if (board[3, 3] == "[ ]")
            //        {
            //            board[3, 3] = xOrO;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThat block has already been taken");
            //            changeTurn();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nInvalid move!");
            //        changeTurn();
            //    }

            //    displayBoard();
            //}

            //public void checkWinner()
            //{
            //    String player = "";
            //    int count = 0;

            //    if (turn == 0)
            //    {
            //        player = "Player 2";
            //    }
            //    else
            //    {
            //        player = "Player 1";
            //    }

            //    if (board[1, 1] == "X" && board[1, 2] == "X" && board[1, 3] == "X" || board[1, 1] == "O" && board[1, 2] == ")" && board[1, 3] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }
            //    else if (board[2, 1] == "X" && board[2, 2] == "X" && board[2, 3] == "X" || board[2, 1] == "O" && board[2, 2] == ")" && board[2, 3] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }
            //    else if (board[3, 1] == "X" && board[3, 2] == "X" && board[3, 3] == "X" || board[3, 1] == "O" && board[3, 2] == ")" && board[3, 3] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }
            //    else if (board[1, 1] == "X" && board[2, 1] == "X" && board[3, 1] == "X" || board[1, 1] == "O" && board[2, 1] == ")" && board[3, 1] == "O")
            //    {

            //        Console.WriteLine(player + " wins");
            //    }
            //    else if (board[1, 2] == "X" && board[2, 2] == "X" && board[3, 2] == "X" || board[1, 2] == "O" && board[2, 2] == ")" && board[3, 2] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }
            //    else if (board[1, 3] == "X" && board[2, 3] == "X" && board[3, 3] == "X" || board[1, 3] == "O" && board[2, 3] == ")" && board[3, 3] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }
            //    else if (board[1, 1] == "X" && board[2, 2] == "X" && board[3, 3] == "X" || board[1, 1] == "O" && board[2, 2] == ")" && board[3, 3] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }
            //    else if (board[1, 3] == "X" && board[2, 2] == "X" && board[3, 1] == "X" || board[1, 3] == "O" && board[2, 2] == ")" && board[3, 1] == "O")
            //    {
            //        Console.WriteLine(player + " wins");
            //        endGame();
            //    }

            //    for (int i = 1; i < 4; i++)
            //    {
            //        for (int j = 1; j < 4; j++)
            //        {
            //            if (board[i, j] != "[ ]")
            //            {
            //                count++;
            //            }
            //        }
            //    }

            //    if (count == 9)
            //    {
            //        Console.WriteLine("\nDraw!");
            //        endGame();
            //    }
            //}

        static void Main(string[] args)
        {
            TicTacToe p = new TicTacToe();
            String block = "";
            p.emptyBoard();
            p.displayBoard();
            Console.WriteLine("\n");

            Console.WriteLine("Player 1: X \t Player 2: O \n");

            while (p.play)
            {
                if (p.turn == 0)
                {
                    Console.Write("\nPlayer 1 turn: ");
                    block = Console.ReadLine();

                    /*
                     * One thing im adding is changing input to Uppercase then sending to parameter
                     * To avoid unnecessary clauses in if statement
                     */

                    block = block.ToUpper();


                    p.setXorO();
                    p.checkMove(block, p.turn);
                    p.changeTurn();
                    p.checkWinner();
                }

                if (p.turn == 1)
                {
                    Console.Write("\nPlayer 2 turn: ");
                    block = Console.ReadLine();

                    /*
                     * One thing im adding is changing input to Uppercase then sending to parameter
                     * To avoid unnecessary clauses in if statement
                     */

                    block = block.ToUpper();


                    p.setXorO();
                    p.checkMove(block, p.turn);
                    p.changeTurn();
                    p.checkWinner();
                }
            }

            Console.ReadLine();
        }
    }
}
