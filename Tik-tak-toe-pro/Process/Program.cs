using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_tak_toe_pro
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
            Setting setting = new Setting();
            setting.difficultyLevel = 1;
            setting.isStartedByPC = false;
            StartForm startForm1 = new StartForm(setting);
            Application.Run(startForm1);
        }
    }
}
