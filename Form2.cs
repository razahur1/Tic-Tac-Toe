using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alien_Invaders
{

    public partial class Form2 : Form
    {
        // Variables
        private bool player1_turn = true;
        private int[,] boardValue = new int[4, 4];
        const int X_VALUE = 1;
        const int O_VALUE = 2;
        

        public Form2(string value1, string value2)
        {
            InitializeComponent();
            restart_matrix();
            player1_turn = true;
            label1.Text = value1;
            label2.Text = value2;
            label5.Text = value1;
            label4.Text = value2;
        }

        // TIC TAC TOE BUTTONS -------------------------------
        private void button1_Click(object sender, EventArgs e) //Button 0,0
        {
            if (player1_turn == true)
            {

                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 0] = O_VALUE;
              
            }

            check_win();
        }

        private void button2_Click(object sender, EventArgs e) //Button 0,1
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 1] = O_VALUE;
            }
            check_win();
        }

        private void button3_Click(object sender, EventArgs e) //Button 0,2
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 2] = O_VALUE;
            }
            check_win();
        }

        private void button14_Click(object sender, EventArgs e)  //Button 0,3
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 3] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 3] = O_VALUE;
            }
            check_win();
        }
        private void button6_Click(object sender, EventArgs e) //Button 1,0
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 0] = O_VALUE;
            }
            check_win();
        }

        private void button5_Click(object sender, EventArgs e) //Button 1,1
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 1] = O_VALUE;
            }
            check_win();
        }

        private void button4_Click(object sender, EventArgs e) //Button 1,2
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 2] = O_VALUE;
            }
            check_win();
        }

        private void button13_Click(object sender, EventArgs e) //Button 1,3
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 3] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 3] = O_VALUE;
            }
            check_win();
        }

        private void button9_Click(object sender, EventArgs e) //Button 2,0
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 0] = O_VALUE;
            }
            check_win();
        }

        private void button8_Click(object sender, EventArgs e) //Button 2,1
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 1] = O_VALUE;
            }
            check_win();
        }

        private void button7_Click(object sender, EventArgs e) //Button 2,2
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 2] = O_VALUE;
            }
            check_win();
        }

        private void button12_Click(object sender, EventArgs e) //Button 2,3
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 3] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 3] = O_VALUE;
            }
            check_win();
        }

        private void button18_Click_1(object sender, EventArgs e)  //Button 3,0
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[3, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[3, 0] = O_VALUE;
            }
            check_win();
        }

        private void button17_Click(object sender, EventArgs e) //Button 3,1
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[3, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[3, 1] = O_VALUE;
            }
            check_win();
        }

        private void button16_Click(object sender, EventArgs e) //Button 3,2
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[3, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[3, 2] = O_VALUE;
            }
            check_win();
        }

        private void button15_Click(object sender, EventArgs e) //Button 3,3
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[3, 3] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[3, 3] = O_VALUE;
            }
            check_win();
        }

        // TIC TAC TOE MATRIX
        private void check_win()
        {
            // Check rows
            for (int i = 0; i < 4; ++i)
            {
                if (Convert.ToInt32(boardValue[i, 0]) == Convert.ToInt32(boardValue[i, 1]) &&
                    Convert.ToInt32(boardValue[i, 1]) == Convert.ToInt32(boardValue[i, 2]) &&
                    Convert.ToInt32(boardValue[i, 2]) == Convert.ToInt32(boardValue[i, 3]) &&
                    Convert.ToInt32(boardValue[i, 2]) != 0)
                {
                    display_win_screen(boardValue[i, 0]);

                    return;
                }
            }

            // Check columns
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[0, i]) == Convert.ToInt32(boardValue[1, i]) &&
                    Convert.ToInt32(boardValue[1, i]) == Convert.ToInt32(boardValue[2, i]) &&
                    Convert.ToInt32(boardValue[2, i]) == Convert.ToInt32(boardValue[3, i]) &&
                    Convert.ToInt32(boardValue[3, i]) != 0)
                {
                    
                    display_win_screen(boardValue[1, i]);
                    return;
                }
            }

            // Check diagonals
            if (Convert.ToInt32(boardValue[0, 0]) == Convert.ToInt32(boardValue[1, 1]) &&
                Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 2]) &&
                Convert.ToInt32(boardValue[2, 2]) == Convert.ToInt32(boardValue[3, 3]) &&
                Convert.ToInt32(boardValue[3, 3]) != 0)
            {
                
                display_win_screen(boardValue[1, 1]);
                return;
            }
            else if (Convert.ToInt32(boardValue[0, 3]) == Convert.ToInt32(boardValue[1, 2]) &&
              Convert.ToInt32(boardValue[1, 2]) == Convert.ToInt32(boardValue[2, 1]) &&
              Convert.ToInt32(boardValue[2, 1]) == Convert.ToInt32(boardValue[3, 0]) &&
              Convert.ToInt32(boardValue[3, 0]) != 0)
            {
                
                display_win_screen(boardValue[1, 1]);
                return;
            }

            // Check draw
            bool is_completed = true;
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; j++)
                    if (boardValue[i, j] == 0)
                        is_completed = false;
            if (is_completed)
            {
                MessageBox.Show("Draw");
                restart_matrix();
            }
        }

        // Display win message
        private void display_win_screen(int val)
        {
            int player1_score;
            int player2_score;
            if (val == X_VALUE)
            {
                MessageBox.Show("Player1 wins!");
                player1_score = Convert.ToInt32(label6.Text);
                ++player1_score;
                label6.Text = player1_score.ToString();
                label6.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Player2 wins!");
                player2_score = Convert.ToInt32(label7.Text);
                ++player2_score;
                label7.Text = player2_score.ToString();
                label7.ForeColor = Color.Red;
            }
            restart_matrix();
        }

        // Restart tic tac toe board
        private void restart_matrix()
        {
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    boardValue[i, j] = 0;

            clear_buttons();
            player1_turn = true;
        }


        // Clear buttons
        private void clear_buttons()
        {
            // Content
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";

            // Back color
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;
            button12.BackColor = Color.Green;
            button13.BackColor = Color.Green;
            button14.BackColor = Color.Green;
            button15.BackColor = Color.Green;
            button16.BackColor = Color.Green;
            button17.BackColor = Color.Green;
            button18.BackColor = Color.Green;


            // Fore color
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            button12.ForeColor = Color.White;
            button13.ForeColor = Color.White;
            button14.ForeColor = Color.White;
            button15.ForeColor = Color.White;
            button16.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
        }

        // Reset game
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(player1_turn == true)
            {
                label1.ForeColor = Color.Purple;
                label2.ForeColor = Color.DarkGray;
                label9.ForeColor = Color.Purple;
                label10.ForeColor = Color.DarkGray;
            }
            else
            {
                label2.ForeColor = Color.Purple;
                label1.ForeColor = Color.DarkGray;
                label10.ForeColor = Color.Purple;
                label9.ForeColor = Color.DarkGray;
            }
        }

        private void button10_MouseHover(object sender, EventArgs e)  //Reset Button
        {
            button10.BackColor = Color.SandyBrown;

        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Chocolate;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
