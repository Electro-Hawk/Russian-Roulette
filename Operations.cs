using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Russian_Roulette
{
    using System.Windows.Forms;
    
    public class Operations
    {
        public int bullets;
        public int ChamberNum;
        public int turn;
        public bool block;
        public int blocks;
        public bool win;
        public int wins;
        public bool loss;
        public int losses;

        public void Load()
        {
            bullets = 1;
        }

        public void SpinChamber()
        {
            Random myRandom = new Random();
            ChamberNum = myRandom.Next(1, 7);

            turn = 1;
            blocks = 2;

            System.Media.SoundPlayer spin = new System.Media.SoundPlayer();
            spin.SoundLocation = @"D:\C# Course 2019\Russian Roulette\Properties\Sounds\Spin.wav";
            spin.Load();
            spin.Play();
        }

        public void Reset()
        {
            turn = 0;
            bullets = 0;
            blocks = 0;
            block = false;
            win = false;
            loss = false;
        }

        public void Block()
        {
            if (blocks > 0)
            {
                block = true;
            }
        }

        public void Fire()
        {
            if (turn < 6 && turn == ChamberNum)
            {
                if (block != true)
                {
                    bullets = 0;
                    loss = true;
                    losses += 1;
                    turn = 7;
                    System.Media.SoundPlayer gunshot = new System.Media.SoundPlayer();
                    gunshot.SoundLocation = @"D:\C# Course 2019\Russian Roulette\Properties\Sounds\Gunshot.wav";
                    gunshot.Load();
                    gunshot.Play();
                }
                else
                {
                    bullets = 0;
                    win = true;
                    wins += 1;
                    turn = 7;
                    System.Media.SoundPlayer ricochet = new System.Media.SoundPlayer();
                    ricochet.SoundLocation = @"D:\C# Course 2019\Russian Roulette\Properties\Sounds\Ricochet.wav";
                    ricochet.Load();
                    ricochet.Play();
                }
            }
            else if (turn < 6 && turn != ChamberNum)
            {
                if (block == true)
                {
                    blocks -= 1;
                    block = false;
                    turn += 1;
                }
                else
                {
                    turn += 1;
                }
            }
        }
    }
}
