namespace Russian_Roulette
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblBullets = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblChamber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(83, 93);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Bullet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(83, 123);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(87, 23);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin Chambers";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(83, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(213, 93);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.BtnFire_Click);
            // 
            // btnAway
            // 
            this.btnAway.Location = new System.Drawing.Point(213, 123);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(75, 23);
            this.btnAway.TabIndex = 4;
            this.btnAway.Text = "Block";
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.BtnAway_Click);
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.Color.LightBlue;
            this.lblWin.Location = new System.Drawing.Point(450, 93);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(100, 23);
            this.lblWin.TabIndex = 5;
            this.lblWin.Text = "Wins: 0";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLose
            // 
            this.lblLose.BackColor = System.Drawing.Color.LightBlue;
            this.lblLose.Location = new System.Drawing.Point(450, 123);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(100, 23);
            this.lblLose.TabIndex = 6;
            this.lblLose.Text = "Losses: 0";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBullets
            // 
            this.lblBullets.BackColor = System.Drawing.Color.IndianRed;
            this.lblBullets.Location = new System.Drawing.Point(313, 93);
            this.lblBullets.Name = "lblBullets";
            this.lblBullets.Size = new System.Drawing.Size(100, 23);
            this.lblBullets.TabIndex = 7;
            this.lblBullets.Text = "Bullets Left: 0";
            this.lblBullets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAway
            // 
            this.lblAway.BackColor = System.Drawing.Color.IndianRed;
            this.lblAway.Location = new System.Drawing.Point(313, 123);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(100, 23);
            this.lblAway.TabIndex = 8;
            this.lblAway.Text = "Blocks Left: 0";
            this.lblAway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChamber
            // 
            this.lblChamber.BackColor = System.Drawing.Color.YellowGreen;
            this.lblChamber.Location = new System.Drawing.Point(313, 153);
            this.lblChamber.Name = "lblChamber";
            this.lblChamber.Size = new System.Drawing.Size(100, 23);
            this.lblChamber.TabIndex = 9;
            this.lblChamber.Text = "Turn: 0";
            this.lblChamber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.Controls.Add(this.lblChamber);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.lblBullets);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblBullets;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label lblChamber;
    }
}

