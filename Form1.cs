using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Form1 : Form
    {
        public int ChamberNum;
        public int turn;
        public int bullets;
        public bool block;
        public int blocks;
        public int wins;
        public int losses;

        Operations Op = new Operations();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //Load the Bullet
            Op.Load();
            lblBullets.Text = "Bullets Left: " + Op.bullets.ToString();
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            //Randomize chamber bullet is in
            //Also sets the chamber back to 1
            Op.SpinChamber();
            lblChamber.Text = "Turn: " + Op.turn.ToString();
            lblAway.Text = "Blocks Left: " + Op.blocks.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //Resets the game
            Op.Reset();
            lblBullets.Text = "Bullets Left: " + Op.bullets.ToString();
            lblChamber.Text = "Turn: " + Op.turn.ToString();
            lblAway.Text = "Blocks Left: " + Op.blocks.ToString();
        }

        private void BtnAway_Click(object sender, EventArgs e)
        {
            Op.Block();
        }

        private void BtnFire_Click(object sender, EventArgs e)
        {
            Op.Fire();
            if (Op.win == true)
            {
                lblBullets.Text = "Bullets Left: " + Op.bullets.ToString();
                lblWin.Text = "Wins: " + Op.wins.ToString();
                lblChamber.Text = "You Win";
            }
            else if (Op.loss == true)
            {
                lblBullets.Text = "Bullets Left: " + Op.bullets.ToString();
                lblLose.Text = "Losses " + Op.losses.ToString();
                lblChamber.Text = "You Lose";
            }
            else
            {
                lblAway.Text = "Blocks Left: " + Op.blocks.ToString();
                lblChamber.Text = "Turn: " + Op.turn.ToString();
            }
        }
    }
}
