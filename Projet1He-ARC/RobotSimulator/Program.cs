using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotSimulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            RobotI monRobot = new Robot(168, 206, 59, 0, 0);

            monRobot.initRobot();
            monRobot.setParamRobot();
            //Form1 fenetre = new Form1();
           Console.WriteLine("Paramètres du robot : "+monRobot.paramRobot);
           Console.ReadLine();
        }
    }
}
