using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    interface RobotI
    {
        //paramètres du robot

        int longueurBrasA
        {
            get;
            set;
        }

        int longueurBrasB
        {
            get;
            set;
        }

        int vitesse
        {
            get;
            set;
        }

        int rotationA
        {
            get;
            set;
        }

        int rotationB
        {
            get;
            set;
        }

        bool init
        {
            get;
            set;
        }

        string pos
        {
            set;
            get;
        }

        bool penActive
        {
            get;
        }

        string paramPen
        {
            get;
            set;
        }

        string paramRobot
        {
            get;
            set;
        }

        void setParamRobot();

        void initRobot();
    }
}
