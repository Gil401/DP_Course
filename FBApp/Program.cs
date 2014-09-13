using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FBApp
{
    public static class Program
    {// $G$ THE-001 (-18) your grade on diagrams document - 69. please see comments inside the document. (40% of your grade).
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FacebookService.s_CollectionLimit = 2000;
            Application.Run(new FormLogin());
        }
    }
}
