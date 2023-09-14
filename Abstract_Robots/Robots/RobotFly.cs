using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        private bool isFlying;
        public int[] legsDirections = { 0, 0, 0, 0 };
        public RobotFly(DateTime creationDate, double batteryStatus) : base("Roboquad", creationDate, batteryStatus)
        { 
            this.isFlying = false;
        }

        public override void MoveBackward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, -1);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            if (this.GetBatteryStatus() >= 12)
            {
                MoveLeg(0, -1);
                MoveLeg(1, -1);
                MoveLeg(2, -1);
                MoveLeg(3, 1);
                MoveLeg(4, 1);
                MoveLeg(5, 1);
            }
            else
            {
                Console.WriteLine(noBatteryMessage);
            }
        }

        public override void TurnRight()
        {
            if (this.GetBatteryStatus() > 8)
            {
                MoveLeg(0, 1);
                MoveLeg(1, 1);
                MoveLeg(2, 1);
                MoveLeg(3, -1);
                MoveLeg(4, -1);
                MoveLeg(5, -1);
            }
            else
            {
                Console.WriteLine(noBatteryMessage);
            }
        }


        private void MoveLeg(int legId, int dir)
        {
            legsDirections[legId] = dir;
            SetBatteryStatus(GetBatteryStatus() - 2);
        }

        public void fly()
        {
            if (this.GetBatteryStatus() > 1.5)
            {
                this.isFlying = true;
            }
            else
            {
                Console.WriteLine(noBatteryMessage);
            }
        }
        public void Stopflight()
        {
            if (this.GetBatteryStatus() > 1.5)
            {
                this.isFlying = false;
            }
            else
            {
                Console.WriteLine(noBatteryMessage);
            }
        }
    }
}
