using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulette
{
    using System.Windows.Forms;
    
    public class Operations
    {
        private int turn = 0;
        public int Bullets(int BulletNum)
        {
            int bulletNumber = 1;
            BulletNum = bulletNumber;

            return BulletNum;
        }
        
        public void ChamberSelect(int ChamberNum)
        {
            Random myRandom = new Random();
            ChamberNum = myRandom.Next(1, 7);
        }

        public int Turn(int TurnNum)
        {
            turn = 1;
            TurnNum = turn;

            return TurnNum;
        }

        public void Fire()
        {
            if (turn < 6)
            {
                turn += 1;
            }
            else if (turn >= 6)
            {
                
            }

        }

        private int ChamberSelect()
        {
            throw new NotImplementedException();
        } 
    }
}
