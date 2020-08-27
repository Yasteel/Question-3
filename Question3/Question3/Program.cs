using System;

namespace Question3
{
    class TicTacToe
    {
        private string[,] board = new String[3,3];
        private int[] coords = new int[2];
        private int player = 1;
        private bool playerOne = true;
        private bool win = false;

        public TicTacToe()
        {
            //Initialise Board//
            int count = 1;
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    this.board[i, j] = count.ToString();

                    count++;
                }
            }

        }

        public void displayRules()
        {
            Console.WriteLine("=======================================" +
                              "\nAvailable Cells Marked with Numbers 1-9" +
                              "\nPlayer 1 - X" +
                              "\nPlayer 2 - O" +
                              "\nChoose who to be Player 1 and Player 2" +
                              "\n=======================================\n");
        }

        public void displayBoard()
        {
            Console.WriteLine("\n   |   |  ");
            Console.WriteLine(" {0} | {1} | {2}", board[0,0], board[0, 1], board[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |  ");
            Console.WriteLine(" {0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |  ");
            Console.WriteLine(" {0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("   |   |  \n");
        }

        public void getMove()
        {
            string move;
            Console.Write("Player {0}:\nEnter cell to Mark: "/*, this.player*/);
            move = Console.ReadLine();

            if (this.validMove(move))
            {
                this.makeMove();
            }
            else
            {
                this.getMove();
            }
        }

        public bool validMove(string move)
        {
            if (Int32.TryParse(move, out int testVar))
            {
                int pos = Convert.ToInt32(move);
                if (pos < 1 || pos > 9)
                {
                    Console.WriteLine("Incorrect Move..");
                    return false;
                }
                else
                {
                    map(pos);

                    if (Int32.TryParse(this.board[this.coords[0], this.coords[1]], out int test))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("This Spot is taken by {0}", this.board[this.coords[0], this.coords[1]]);
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input..");
                return false;
            }
        }

        public void makeMove()
        {
            //if (player == 1)
            //{
            //    this.board[this.coords[0], this.coords[1]] = "X";
            //    this.player = 2;
            //}
            //else
            //{
            //    this.board[this.coords[0], this.coords[1]] = "O";
            //    this.player = 1;
            //}

            if (playerOne)
            {
                Console.WriteLine("Player 1:{0}", playerOne);
                this.board[this.coords[0], this.coords[1]] = "X";
            }
            else
            {
                Console.WriteLine("Player 1:{0}", playerOne);
                this.board[this.coords[0], this.coords[1]] = "O";
            }

            this.playerOne = !this.playerOne;

            //switch (this.player)
            //{
            //    case 1: this.board[this.coords[0], this.coords[1]] = "X"; this.player = 2; break;
            //    case 2: this.board[this.coords[0], this.coords[1]] = "O"; this.player = 2; break;
            //}
            this.checkWin();
        }

        public void map(int selection)
        {
            switch (selection)
            {   
                case 1: this.coords[0] = 0; this.coords[1] = 0; break;
                case 2: this.coords[0] = 0; this.coords[1] = 1; break;
                case 3: this.coords[0] = 0; this.coords[1] = 2; break;
                case 4: this.coords[0] = 1; this.coords[1] = 0; break;
                case 5: this.coords[0] = 1; this.coords[1] = 1; break;
                case 6: this.coords[0] = 1; this.coords[1] = 2; break;
                case 7: this.coords[0] = 2; this.coords[1] = 0; break;
                case 8: this.coords[0] = 2; this.coords[1] = 1; break;
                case 9: this.coords[0] = 2; this.coords[1] = 2; break;
            }
        }

        public void checkWin()
        {
            for (int i = 0; i < 3; i++) {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    this.win = true;
                }
                if (board[0,i] == board[1,i] && board[0,i] == board[2,i])
                {
                    this.win = true;
                }
            }

            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                this.win = true;
            }

            if (board[0, 2] == board[1, 1] && board[0, 2] == board[1, 0])
            {
                this.win = true;
            }


        }

        public void start()
        {
            while (!win)
            {
                this.displayBoard();
                this.getMove();
                this.makeMove();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool firstGame = true;
            bool stop = false;
            string ans;

            while (!stop)
            {
                if (!firstGame)
                {
                    TicTacToe game = new TicTacToe();

                    Console.Write("Play again? (Y/N): ");
                    ans = Console.ReadLine();
                    ans = ans.ToUpper();

                    if (ans == "Y")
                    {
                        Console.Clear();
                        game.displayRules();
                        game.start();
                    }else if(ans == "N")
                    {
                        stop = !stop;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Option...\n");
                    }
                }
                else
                {
                    firstGame = false;
                    TicTacToe game = new TicTacToe();
                    game.displayRules();
                    game.start();
                }
            }
            

            Console.ReadLine();
        }
    }
}
