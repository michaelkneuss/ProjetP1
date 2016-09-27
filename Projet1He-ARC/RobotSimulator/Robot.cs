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
            get
            {
                return init;
            }

            set
            {
                init = value;
            }
        }

        public int longueurBrasA
        {
            get
            {
                return longueurBrasA;
            }

            set
            {
                longueurBrasA = value;
            }
        }

        public int longueurBrasB
        {
            get
            {
                return longueurBrasB;
            }

            set
            {
                longueurBrasB = value;
            }
        }

        public bool penActive
        {
            get
            {
                return penActive;
            }
        }

        public string pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }

        public string paramPen
        {
            get
            {
                return paramPen;
            }

            set
            {
                paramPen = value;
            }
        }

        public string paramRobot
        {
            get
            {
                return paramRobot;
            }

            set
            {
                paramRobot = value;
            }
        }

        public int vitesse
        {
            get
            {
                return vitesse;
            }

            set
            {
                vitesse = value;
            }
        }

        public int rotationA
        {
            get
            {
                return rotationA;
            }

            set
            {
                rotationA = value;
            }
        }

        public int rotationB
        {
            get
            {
                return rotationB;
            }

            set
            {
                rotationB = value;
            }
        }

        public Robot(int longueurBrasA, int longueurBrasB, int vitesse, int rotationA, int rotationB)
        {
            this.longueurBrasA = longueurBrasA;
            this.longueurBrasA = longueurBrasB;
            this.pos = "G1 X-374 Y0<0x0A>";
            this.paramRobot = "M5 A"+rotationA+" B"+rotationB+" M"+longueurBrasA+" N"+longueurBrasB+" D"+vitesse +"<0x0A>";
        }

        void RobotI.setParamRobot()
        {
            this.paramRobot = "M5 A" + rotationA + " B" + rotationB + " M" + longueurBrasA + " N" + longueurBrasB + " D" + vitesse + "<0x0A>";
        }
    }
}
