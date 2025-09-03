using System;
using System.Windows.Forms;

namespace quizz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Voor testen: direct FormAdmin openen
           //Application.Run(new FormAdmin());

            // Start met FormLogin
           Application.Run(new FormLogin());
        }
    }
}
