using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, turnOfPlayer2, twoPlayerMode;
        int PointsOfPlayer;
        int PointsOfComputer;

        private void btnPos5_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos5 = true;
                lblPos5.Text = "X";
                btnPos5.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos5 = true;
                    lblPos5.Text = "X";
                    btnPos5.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos5 = true;
                    lblPos5.Text = "O";
                    btnPos5.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos6_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos6 = true;
                lblPos6.Text = "X";
                btnPos6.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos6 = true;
                    lblPos6.Text = "X";
                    btnPos6.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos6 = true;
                    lblPos6.Text = "O";
                    btnPos6.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos7_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos7 = true;
                lblPos7.Text = "X";
                btnPos7.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos7 = true;
                    lblPos7.Text = "X";
                    btnPos7.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos7 = true;
                    lblPos7.Text = "O";
                    btnPos7.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos8_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos8 = true;
                lblPos8.Text = "X";
                btnPos8.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos8 = true;
                    lblPos8.Text = "X";
                    btnPos8.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos8 = true;
                    lblPos8.Text = "O";
                    btnPos8.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos9_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos9 = true;
                lblPos9.Text = "X";
                btnPos9.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos9 = true;
                    lblPos9.Text = "X";
                    btnPos9.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos9 = true;
                    lblPos9.Text = "O";
                    btnPos9.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos4_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos4 = true;
                lblPos4.Text = "X";
                btnPos4.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos4 = true;
                    lblPos4.Text = "X";
                    btnPos4.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos4 = true;
                    lblPos4.Text = "O";
                    btnPos4.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos3_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos3 = true;
                lblPos3.Text = "X";
                btnPos3.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos3 = true;
                    lblPos3.Text = "X";
                    btnPos3.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos3 = true;
                    lblPos3.Text = "O";
                    btnPos3.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void btnPos2_Click(object sender, EventArgs e)
        {
            if (!twoPlayerMode)
            {
                pos2 = true;
                lblPos2.Text = "X";
                btnPos2.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode)
            {
                if (!turnOfPlayer2)
                {
                    pos2 = true;
                    lblPos2.Text = "X";
                    btnPos2.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else
                {
                    pos2 = true;
                    lblPos2.Text = "O";
                    btnPos2.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (twoPlayerMode == true)
            {
                EnableAllButtons();
                twoPlayerMode = false;
                lblPos1.Text = null;
                lblPos2.Text = null;
                lblPos3.Text = null;
                lblPos4.Text = null;
                lblPos5.Text = null;
                lblPos6.Text = null;
                lblPos7.Text = null;
                lblPos8.Text = null;
                lblPos9.Text = null;
                pos1 = false;
                pos2 = false;
                pos3 = false;
                pos4 = false;
                pos5 = false;
                pos6 = false;
                pos7 = false;
                pos8 = false;
                pos9 = false;
                PointsOfComputer = 0;
                PointsOfPlayer = 0;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (twoPlayerMode == false)
            {
                EnableAllButtons();
                lblPos1.Text = null;
                lblPos2.Text = null;
                lblPos3.Text = null;
                lblPos4.Text = null;
                lblPos5.Text = null;
                lblPos6.Text = null;
                lblPos7.Text = null;
                lblPos8.Text = null;
                lblPos9.Text = null;
                pos1 = false;
                pos2 = false;
                pos3 = false;
                pos4 = false;
                pos5 = false;
                pos6 = false;
                pos7 = false;
                pos8 = false;
                pos9 = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (twoPlayerMode == true)
            {
                EnableAllButtons();
                twoPlayerMode = true;
                lblPos1.Text = null;
                lblPos2.Text = null;
                lblPos3.Text = null;
                lblPos4.Text = null;
                lblPos5.Text = null;
                lblPos6.Text = null;
                lblPos7.Text = null;
                lblPos8.Text = null;
                lblPos9.Text = null;
                pos1 = false;
                pos2 = false;
                pos3 = false;
                pos4 = false;
                pos5 = false;
                pos6 = false;
                pos7 = false;
                pos8 = false;
                pos9 = false;
            }
            else if (twoPlayerMode == false)
            {
                EnableAllButtons();
                twoPlayerMode = true;
                lblPos1.Text = null;
                lblPos2.Text = null;
                lblPos3.Text = null;
                lblPos4.Text = null;
                lblPos5.Text = null;
                lblPos6.Text = null;
                lblPos7.Text = null;
                lblPos8.Text = null;
                lblPos9.Text = null;
                pos1 = false;
                pos2 = false;
                pos3 = false;
                pos4 = false;
                pos5 = false;
                pos6 = false;
                pos7 = false;
                pos8 = false;
                pos9 = false;
                PointsOfComputer = 0;
                PointsOfPlayer = 0;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPos1_Click(object sender, EventArgs e)
        {
            if (twoPlayerMode == false)
            {
                pos1 = true;
                lblPos1.Text = "X";
                btnPos1.Enabled = false;
                ComputerSellection();
                CheckForPlayer();
            }
            else if (twoPlayerMode == true)
            {
                if (turnOfPlayer2 == false)
                {
                    pos1 = true;
                    lblPos1.Text = "X";
                    btnPos1.Enabled = false;
                    CheckForPlayer();
                    turnOfPlayer2 = true;
                }
                else if(turnOfPlayer2 == true)
                {
                    pos1 = true;
                    lblPos1.Text = "O";
                    btnPos1.Enabled = false;
                    CheckForPlayer2();
                    turnOfPlayer2 = false;
                }
            }
        }
        public void ComputerSellection()
        {
            Random selection = new Random();
            int selectedPos = selection.Next(1,10);
            while (true)
            {
                if (selectedPos== 1)
                {
                    if (!pos1)
                    {
                        pos1 = true;
                        lblPos1.Text = "O";
                        btnPos1.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1,10);
                    }
                }
                if (selectedPos == 2)
                {
                    if (!pos2)
                    {
                        pos2 = true;
                        lblPos2.Text = "O";
                        btnPos2.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 3)
                {
                    if (!pos3)
                    {
                        pos3 = true;
                        lblPos3.Text = "O";
                        btnPos3.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 4)
                {
                    if (!pos4)
                    {
                        pos4 = true;
                        lblPos4.Text = "O";
                        btnPos4.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 5)
                {
                    if (!pos5)
                    {
                        pos5 = true;
                        lblPos5.Text = "O";
                        btnPos5.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 6)
                {
                    if (!pos6)
                    {
                        pos6 = true;
                        lblPos6.Text = "O";
                        btnPos6.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 7)
                {
                    if (!pos7)
                    {
                        pos7 = true;
                        lblPos7.Text = "O";
                        btnPos7.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 8)
                {
                    if (!pos8)
                    {
                        pos8 = true;
                        lblPos8.Text = "O";
                        btnPos8.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (selectedPos == 9)
                {
                    if (!pos9)
                    {
                        pos9 = true;
                        lblPos9.Text = "O";
                        btnPos9.Enabled = false;
                        CheckForComputer();
                        break;
                    }
                    else
                    {
                        selectedPos = selection.Next(1, 10);
                    }
                }
                if (pos1 && pos2 && pos3 && pos4 && pos5 && pos6 && pos7 && pos8 && pos9)
                {
                    break;
                }
            }
        }
        public void DisableAllButtons()
        {
            btnPos1.Enabled = false;
            btnPos2.Enabled = false;
            btnPos3.Enabled = false;
            btnPos4.Enabled = false;
            btnPos5.Enabled = false;
            btnPos6.Enabled = false;
            btnPos7.Enabled = false;
            btnPos8.Enabled = false;
            btnPos9.Enabled = false;
        }
        public void EnableAllButtons()
        {
            btnPos1.Enabled = true;
            btnPos2.Enabled = true;
            btnPos3.Enabled = true;
            btnPos4.Enabled = true;
            btnPos5.Enabled = true;
            btnPos6.Enabled = true;
            btnPos7.Enabled = true;
            btnPos8.Enabled = true;
            btnPos9.Enabled = true;
        }
        public void CheckForPlayer()
        {
            if (lblPos1.Text == "X" && lblPos2.Text == "X" && lblPos3.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos4.Text == "X" && lblPos5.Text == "X" && lblPos6.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos7.Text == "X" && lblPos8.Text == "X" && lblPos9.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos1.Text == "X" && lblPos5.Text == "X" && lblPos9.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos7.Text == "X" && lblPos5.Text == "X" && lblPos3.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos1.Text == "X" && lblPos4.Text == "X" && lblPos7.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos2.Text == "X" && lblPos5.Text == "X" && lblPos8.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
            else if (lblPos3.Text == "X" && lblPos6.Text == "X" && lblPos9.Text == "X")
            {
                DisableAllButtons();
                MessageBox.Show("Player 1 Wins!", "Congrats");
                PointsOfPlayer++;
                lblPlayerPoints.Text = PointsOfPlayer.ToString();
            }
        }
        public void CheckForPlayer2()
        {
            if (lblPos1.Text == "O" && lblPos2.Text == "O" && lblPos3.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos4.Text == "O" && lblPos5.Text == "O" && lblPos6.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos7.Text == "O" && lblPos8.Text == "O" && lblPos9.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos1.Text == "O" && lblPos5.Text == "O" && lblPos9.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos7.Text == "O" && lblPos5.Text == "O" && lblPos3.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos1.Text == "O" && lblPos4.Text == "O" && lblPos7.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos2.Text == "O" && lblPos5.Text == "O" && lblPos8.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos3.Text == "O" && lblPos6.Text == "O" && lblPos9.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("Player 2 Wins!", "Congrats");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
        }
        public void CheckForComputer()
        {
            if (lblPos1.Text == "O" && lblPos2.Text == "O" && lblPos3.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos4.Text == "O" && lblPos5.Text == "O" && lblPos6.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos7.Text == "O" && lblPos8.Text == "O" && lblPos9.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos1.Text == "O" && lblPos5.Text == "O" && lblPos9.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos7.Text == "O" && lblPos5.Text == "O" && lblPos3.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos1.Text == "O" && lblPos4.Text == "O" && lblPos7.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos2.Text == "O" && lblPos5.Text == "O" && lblPos8.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
            else if (lblPos3.Text == "O" && lblPos6.Text == "O" && lblPos9.Text == "O")
            {
                DisableAllButtons();
                MessageBox.Show("You lose :(", "Try Again");
                PointsOfComputer++;
                lblComputerPoints.Text = PointsOfComputer.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
            DisableAllButtons();
            lblPos1.Text = null;
            lblPos2.Text = null;
            lblPos3.Text = null;
            lblPos4.Text = null;
            lblPos5.Text = null;
            lblPos6.Text = null;
            lblPos7.Text = null;
            lblPos8.Text = null;
            lblPos9.Text = null;
            pos1 = false;
            pos2 = false;
            pos3 = false;
            pos4 = false;
            pos5 = false;
            pos6 = false;
            pos7 = false;
            pos8 = false;
            pos9 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
