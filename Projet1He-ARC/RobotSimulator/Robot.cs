using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    class Robot : RobotI
    {

        public bool init
        {
            get; set;
        }

        public int longueurBrasA
        {
            get;set;
        }

        public int longueurBrasB
        {
            get;set;
        }

        public bool penActive
        {
            get;set;
        }

        public string pos
        {
            get;set;
        }

        public string paramPen
        {
            get;set;
        }

        public string paramRobot
        {
            get;set;
        }

        public int vitesse
        {
            get;set;
        }

        public int rotationA
        {
            get;set;
        }

        public int rotationB
        {
            get;set;
        }

        public Robot(int _longueurBrasA, int _longueurBrasB, int _vitesse, int _rotationA, int _rotationB)
        {
            longueurBrasA = _longueurBrasA;
            longueurBrasB = _longueurBrasB;
            pos = "G1 X-374 Y0<0x0A>";
            vitesse = _vitesse;
            rotationA = _rotationA;
            rotationB = _rotationB;
        }

        public Robot()
        {
        }

        void RobotI.setParamRobot()
        {
            this.paramRobot = "M5 A" + rotationA + " B" + rotationB + " M" + longueurBrasA + " N" + longueurBrasB + " D" + vitesse + "<0x0A>";
        }

        void RobotI.initRobot ()
        {
            //envoyer "M10<0x0A> au robot
            if (true) //TODO
                this.init = true;
            else
                this.init = false;
        }
    }
}
