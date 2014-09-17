using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FBApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FacebookService.s_CollectionLimit = 2000;
            Application.Run(new LoginForm());
        }
    }
}
