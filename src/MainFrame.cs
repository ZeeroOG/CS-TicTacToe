using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "")
            {
                this.button1.Text = "X";
                nextMove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "")
            {
                this.button2.Text = "X";
                nextMove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.Text == "")
            {
                this.button3.Text = "X";
                nextMove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.Text == "")
            {
                this.button4.Text = "X";
                nextMove();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.Text == "")
            {
                this.button5.Text = "X";
                nextMove();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button6.Text == "")
            {
                this.button6.Text = "X";
                nextMove();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button7.Text == "")
            {
                this.button7.Text = "X";
                nextMove();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.button8.Text == "")
            {
                this.button8.Text = "X";
                nextMove();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button9.Text == "")
            {
                this.button9.Text = "X";
                nextMove();
            }
        }

        private void nextMove()
        {
            if (IsGameFinished() == true)
            {
                return;
            }
            
            int[] table = new int[10];
            int[] level = new int[10];
            level[0] = -2;
            int somme = 0;

            if (this.button1.Text == "O") { table[1] = 10; }
            else if (this.button1.Text == "X") { table[1] = 1; }
            else { table[1] = 0; }

            if (this.button2.Text == "O") { table[2] = 10; }
            else if (this.button2.Text == "X") { table[2] = 1; }
            else { table[2] = 0; }

            if (this.button3.Text == "O") { table[3] = 10; }
            else if (this.button3.Text == "X") { table[3] = 1; }
            else { table[3] = 0; }

            if (this.button4.Text == "O") { table[4] = 10; }
            else if (this.button4.Text == "X") { table[4] = 1; }
            else { table[4] = 0; }

            if (this.button5.Text == "O") { table[5] = 10; }
            else if (this.button5.Text == "X") { table[5] = 1; }
            else { table[5] = 0; }

            if (this.button6.Text == "O") { table[6] = 10; }
            else if (this.button6.Text == "X") { table[6] = 1; }
            else { table[6] = 0; }

            if (this.button7.Text == "O") { table[7] = 10; }
            else if (this.button7.Text == "X") { table[7] = 1; }
            else { table[7] = 0; }

            if (this.button8.Text == "O") { table[8] = 10; }
            else if (this.button8.Text == "X") { table[8] = 1; }
            else { table[8] = 0; }

            if (this.button9.Text == "O") { table[9] = 10; }
            else if (this.button9.Text == "X") { table[9] = 1; }
            else { table[9] = 0; }

            somme = table[1] + table[2] + table[3];
            if (somme == 10)
            {
                level[1]++;
                level[2]++;
                level[3]++;
            }
            else if (somme == 20)
            {
                level[1]++;
                level[1]++;
                level[2]++;
                level[2]++;
                level[3]++;
                level[3]++;
            }
            else if (somme == 2)
            {
                level[1] += 100;
                level[2] += 100;
                level[3] += 100;
            }

            somme = table[3] + table[6] + table[9];
            if (somme == 10)
            {
                level[3]++;
                level[6]++;
                level[9]++;
            }
            else if (somme == 20)
            {
                level[3]++;
                level[3]++;
                level[6]++;
                level[6]++;
                level[9]++;
                level[9]++;
            }
            else if (somme == 2)
            {
                level[3] += 100;
                level[6] += 100;
                level[9] += 100;
            }

            somme = table[7] + table[8] + table[9];
            if (somme == 10)
            {
                level[7]++;
                level[8]++;
                level[9]++;
            }
            else if (somme == 20)
            {
                level[7]++;
                level[7]++;
                level[8]++;
                level[8]++;
                level[9]++;
                level[9]++;
            }
            else if (somme == 2)
            {
                level[7] += 100;
                level[8] += 100;
                level[9] += 100;
            }

            somme = table[1] + table[4] + table[7];
            if (somme == 10)
            {
                level[1]++;
                level[4]++;
                level[7]++;
            }
            else if (somme == 20)
            {
                level[1]++;
                level[1]++;
                level[4]++;
                level[4]++;
                level[7]++;
                level[7]++;
            }
            else if (somme == 2)
            {
                level[1] += 100;
                level[4] += 100;
                level[7] += 100;
            }

            somme = table[2] + table[5] + table[8];
            if (somme == 10)
            {
                level[2]++;
                level[5]++;
                level[8]++;
            }
            else if (somme == 20)
            {
                level[2]++;
                level[2]++;
                level[5]++;
                level[5]++;
                level[8]++;
                level[8]++;
            }
            else if (somme == 2)
            {
                level[2] += 100;
                level[5] += 100;
                level[8] += 100;
            }

            somme = table[4] + table[5] + table[6];
            if (somme == 10)
            {
                level[4]++;
                level[5]++;
                level[6]++;
            }
            else if (somme == 20)
            {
                level[4]++;
                level[4]++;
                level[5]++;
                level[5]++;
                level[6]++;
                level[6]++;
            }
            else if (somme == 2)
            {
                level[4] += 100;
                level[5] += 100;
                level[6] += 100;
            }

            somme = table[1] + table[5] + table[9];
            if (somme == 10)
            {
                level[1]++;
                level[5]++;
                level[9]++;
            }
            else if (somme == 20)
            {
                level[1]++;
                level[1]++;
                level[5]++;
                level[5]++;
                level[9]++;
                level[9]++;
            }
            else if (somme == 2)
            {
                level[1] += 100;
                level[5] += 100;
                level[9] += 100;
            }

            somme = table[3] + table[5] + table[7];
            if (somme == 10)
            {
                level[3]++;
                level[5]++;
                level[7]++;
            }
            else if (somme == 20)
            {
                level[3]++;
                level[3]++;
                level[5]++;
                level[5]++;
                level[7]++;
                level[7]++;
            }
            else if (somme == 2)
            {
                level[3] += 100;
                level[5] += 100;
                level[7] += 100;
            }

            if (this.button1.Text != "") { level[1] = -1; }
            if (this.button2.Text != "") { level[2] = -1; }
            if (this.button3.Text != "") { level[3] = -1; }
            if (this.button4.Text != "") { level[4] = -1; }
            if (this.button5.Text != "") { level[5] = -1; }
            if (this.button6.Text != "") { level[6] = -1; }
            if (this.button7.Text != "") { level[7] = -1; }
            if (this.button8.Text != "") { level[8] = -1; }
            if (this.button9.Text != "") { level[9] = -1; }

            if (level.ToList().IndexOf(level.Max()) == 1)
            {
                this.button1.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 2)
            {
                this.button2.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 3)
            {
                this.button3.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 4)
            {
                this.button4.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 5)
            {
                this.button5.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 6)
            {
                this.button6.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 7)
            {
                this.button7.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 8)
            {
                this.button8.Text = "O";
            }

            if (level.ToList().IndexOf(level.Max()) == 9)
            {
                this.button9.Text = "O";
            }

            IsGameFinished();
        }

        private bool IsGameFinished()
        {
            int[] table = new int[10];
            int somme = 0;

            if (this.button1.Text == "O") { table[1] = 10; }
            else if (this.button1.Text == "X") { table[1] = 1; }
            else { table[1] = 0; }

            if (this.button2.Text == "O") { table[2] = 10; }
            else if (this.button2.Text == "X") { table[2] = 1; }
            else { table[2] = 0; }

            if (this.button3.Text == "O") { table[3] = 10; }
            else if (this.button3.Text == "X") { table[3] = 1; }
            else { table[3] = 0; }

            if (this.button4.Text == "O") { table[4] = 10; }
            else if (this.button4.Text == "X") { table[4] = 1; }
            else { table[4] = 0; }

            if (this.button5.Text == "O") { table[5] = 10; }
            else if (this.button5.Text == "X") { table[5] = 1; }
            else { table[5] = 0; }

            if (this.button6.Text == "O") { table[6] = 10; }
            else if (this.button6.Text == "X") { table[6] = 1; }
            else { table[6] = 0; }

            if (this.button7.Text == "O") { table[7] = 10; }
            else if (this.button7.Text == "X") { table[7] = 1; }
            else { table[7] = 0; }

            if (this.button8.Text == "O") { table[8] = 10; }
            else if (this.button8.Text == "X") { table[8] = 1; }
            else { table[8] = 0; }

            if (this.button9.Text == "O") { table[9] = 10; }
            else if (this.button9.Text == "X") { table[9] = 1; }
            else { table[9] = 0; }

            somme = table[1] + table[2] + table[3];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[3] + table[6] + table[9];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[7] + table[8] + table[9];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[1] + table[4] + table[7];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[2] + table[5] + table[8];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[4] + table[5] + table[6];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[1] + table[5] + table[9];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            somme = table[3] + table[5] + table[7];
            if (somme == 3)
            {
                WhoWon(2);
                return true;
            }
            else if (somme == 30)
            {
                WhoWon(1);
                return true;
            }

            if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                WhoWon(0);
                return true;
            }

            return false;
        }

        private void WhoWon(int WhoWon)
        {
            String Message = "";
            if (WhoWon == 0) { Message = "Draw !"; }
            else if (WhoWon == 1) { Message = "You lost !"; }
            else if (WhoWon == 2) { Message = "You win !"; }
            var reponse = MessageBox.Show(Message + "\nPlay again ?", "Game over !", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (reponse == DialogResult.No)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.button1.Text = "";
                this.button2.Text = "";
                this.button3.Text = "";
                this.button4.Text = "";
                this.button5.Text = "";
                this.button6.Text = "";
                this.button7.Text = "";
                this.button8.Text = "";
                this.button9.Text = "";

                this.button1.Focus();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ZeeroOG/");
        }
    }
}
