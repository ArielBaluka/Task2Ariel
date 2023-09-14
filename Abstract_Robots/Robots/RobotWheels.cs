using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class Wheel
    {
        private int right;
        private int left;

        public Wheel()
        {
            this.right = 0;
            this.left = 0;
        }
        public Wheel(int right, int left)
        {
            this.right = right;
            this.left = left;
        }
        
        public void SetRight(int right) { this.right = right; }
        public void SetLeft(int left) { this.left = left; }
        public int GetRight() { return this.right; }
        public int GetLeft() { return this.left; }
    }
    public class RobotWheels : RobotSpy
    {
        public Wheel[] wheels;
        public RobotWheels(DateTime creationDate, double batteryStatus) : base("Spyke", creationDate, batteryStatus) 
        { 
            this.wheels = new Wheel[6];
            for (int i = 0; i < wheels.Length; i++)
            {
                this.wheels[i] = new Wheel();
            }
        } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void MoveBackward()
        {
            this.TurnWheels(-1, -1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }
        public override void TurnLeft()
        {
            this.TurnWheels(0, -1);
        }

        private void TurnWheels(int rightDir, int leftDir)
        {
            if(this.GetBatteryStatus() > 4.5)
            {
                for (int i = 0; i < wheels.Length; i++)
                {
                    wheels[i].SetLeft(leftDir);
                    wheels[i].SetRight(rightDir);
                }
                this.SetBatteryStatus(this.GetBatteryStatus() - 4.5);
            }
            else
            {
                Console.WriteLine(noBatteryMessage);
            }

        }

        public void WaveHands()
        {
            if (this.GetBatteryStatus() > 2)
            {
                Console.WriteLine("mooving hands");
                this.SetBatteryStatus(this.GetBatteryStatus() - 2);
            }
            else
            {
                Console.WriteLine(noBatteryMessage);
            }
        }

       
    }
}
