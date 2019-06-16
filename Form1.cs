using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Form1 : Form
    {
        Operations Op = new Operations();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //Load the Bullet
            lblBullets.Text = "Bullets Left: " + Op.Bullets(1).ToString();
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            //Randomize chamber bullet is in
            //Also sets the chamber back to 1
            Op.ChamberSelect(1);
            Op.Turn(1);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //Reset 
            lblBullets.Text = "Bullets Left: " + Op.Bullets(1).ToString();
            lblChamber.Text = "Chamber: " + Op.Turn(1).ToString();
        }

        private void BtnAway_Click(object sender, EventArgs e)
        {

        }

        private void BtnFire_Click(object sender, EventArgs e)
        {
            Op.Fire();
        }
    }
}
