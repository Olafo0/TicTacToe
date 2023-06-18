using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public class Game
    {
        int x = 0;
        public bool p = true;
        string [,] arr = new string [3, 3];



        public void GameTurn(Button button)
        {
            var location = button.Name.Substring(6, 1);
            Console.WriteLine(location);
            int num = Convert.ToInt32(location);

            if (x == 0)
            {
                Console.WriteLine("NUM IS : {0}", num);
                if (button.Text == "")
                {
                    button.Text = "O";
                    button.Enabled = false;
                    x = 1;

                    if (num < 4)
                    {
                        Console.WriteLine("CURRENTL ON ROW ONE");
                        if (num == 1)
                        {
                            arr[0, 0] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[0, 0]);
                        }
                        else if (num == 2)
                        {
                            arr[0, 1] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[0, 1]);
                        }
                        else if (num == 3)
                        {
                            arr[0, 2] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[0, 2]);
                        }
                    }
                    if ((num < 7)  && (num > 3))
                    {
                        Console.WriteLine("CURRENTL ON ROW TWO");
                        if (num == 4)
                        {
                            arr[1, 0] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[1, 0]);
                        }
                        else if (num == 5)
                        {
                            arr[1, 1] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[1, 1]);
                        }
                        else if (num == 6)
                        {
                            arr[1, 2] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[1, 2]);
                        }
                    }
                    if ((num < 10) && (num > 6))
                    {
                        Console.WriteLine("CURRENTL ON ROW THREE");
                        if (num == 7)
                        {
                            arr[2, 0] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[2, 0]);
                        }
                        else if (num == 8)
                        {
                            arr[2, 1] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[2, 1]);
                        }
                        else if (num == 9)
                        {
                            arr[2, 2] = "O";
                            Console.WriteLine("O ADDED TO {0}", arr[2, 2]);
                        }
                    }


                }
            }
            else if (x == 1)
            {
                if (button.Text == "")
                {
                    button.Text = "X";
                    button.Enabled = false;
                    x = 0;

                    Console.WriteLine("NUM IS : {0}", num);
                    if (num < 4)
                    {
                        Console.WriteLine("CURRENTL ON ROW ONE");
                        if (num == 1)
                        {
                            arr[0, 0] = "X";
                            Console.WriteLine("O ADDED TO {0}", arr[0, 0]);
                        }
                        else if (num == 2)
                        {
                            arr[0, 1] = "X";
                            Console.WriteLine("O ADDED TO {0}", arr[0, 1]);
                        }
                        else if (num == 3)
                        {
                            arr[0, 2] = "X";
                            Console.WriteLine("O ADDED TO {0}", arr[0, 2]);
                        }
                    }
                    if ((num < 7) && (num > 3))
                    {
                        Console.WriteLine("CURRENTL ON ROW TWO");
                        if (num == 4)
                        {
                            arr[1, 0] = "X";
                            Console.WriteLine("X ADDED TO {0}", arr[1, 0]);
                        }
                        else if (num == 5)
                        {
                            arr[1, 1] = "X";
                            Console.WriteLine("X ADDED TO {0}", arr[1, 1]);
                        }
                        else if (num == 6)
                        {
                            arr[1, 2] = "X";
                            Console.WriteLine("X ADDED TO {0}", arr[1, 2]);
                        }
                    }
                    if ((num < 10) && (num > 6))
                    {
                        Console.WriteLine("CURRENTL ON ROW THREE");
                        if (num == 7)
                        {
                            arr[2, 0] = "X";
                            Console.WriteLine("X ADDED TO {0}", arr[2, 0]);
                        }
                        else if (num == 8)
                        {
                            arr[2, 1] = "X";
                            Console.WriteLine("X ADDED TO {0}", arr[2, 1]);
                        }
                        else if (num == 9)
                        {
                            arr[2, 2] = "X";
                            Console.WriteLine("X ADDED TO {0}", arr[2, 2]);
                        }
                    }
                }

            }
        }
        public bool HasWon(Button button)
        {
            Console.WriteLine("Im working");
            // horz row 0 
            if ((arr[0,0] == "O") && (arr[0, 1] == "O") && (arr[0, 2] == "O") || (arr[0, 0] == "X") && (arr[0, 1] == "X") && (arr[0, 2] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title =  "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            // Horz row 1
            if ((arr[1, 0] == "O") && (arr[1, 1] == "O") && (arr[1, 2] == "O") || (arr[1, 0] == "X") && (arr[1, 1] == "X") && (arr[1, 2] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            // Horz row 3
            if ((arr[2, 0] == "O") && (arr[2, 1] == "O") && (arr[2, 2] == "O") || (arr[2, 0] == "X") && (arr[2, 1] == "X") && (arr[2, 2] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

            // Vert 0
            if ((arr[0, 0] == "O") && (arr[1, 0] == "O") && (arr[2, 0] == "O") || (arr[0, 0] == "X") && (arr[1, 0] == "X") && (arr[2, 0] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            // Vert 1
            if ((arr[0, 1] == "O") && (arr[1, 1] == "O") && (arr[2, 1] == "O") || (arr[0, 1] == "X") && (arr[1, 1] == "X") && (arr[2, 1] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            // Vert 2
            if ((arr[0, 2] == "O") && (arr[1, 2] == "O") && (arr[2, 2] == "O") || (arr[0, 2] == "X") && (arr[1, 2] == "X") && (arr[2, 2] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

            // Dia 1
            if ((arr[0, 0] == "O") && (arr[1, 1] == "O") && (arr[2, 2] == "O") || (arr[0, 0] == "X") && (arr[1, 1] == "X") && (arr[2, 2] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            // Dia 1
            if ((arr[0, 2] == "O") && (arr[1, 1] == "O") && (arr[2, 0] == "O") || (arr[0, 2] == "X") && (arr[1, 1] == "X") && (arr[2, 0] == "X"))
            {
                Console.WriteLine("Player has won");
                MessageBox.Show("Player has won");
                string msg = "Do you want to play again";
                string title = "Play again?";

                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);

                if (result == DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

            return false;



        }

    }
}
