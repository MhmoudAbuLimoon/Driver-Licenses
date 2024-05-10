using DrivingLisenceApp.Pepole;
using DrivingLisenceApp.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLisenceApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());
            //  Application.Run(new frmAddUpdatePerson(1078));
            // Application.Run(new frmFindPerson());
            // Application.Run(new frmShowPersonInfo("N1"));
            // Application.Run(new frmListPeople());
            //  Application.Run(new frmAddUpdateUser());
            //  Application.Run(new frmUserInfo(37));
            // Application.Run(new frmChangePassword(37));
           // Application.Run(new frmAddUpdatePerson());
            Application.Run(new frmAddUpdatePerson());
        }
    }
}
