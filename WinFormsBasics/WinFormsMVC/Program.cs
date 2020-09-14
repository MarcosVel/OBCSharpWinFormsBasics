using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserInfo info = new UserInfo();

            var f1 = new FirstForm();
            f1.UserInfo = info;
            f1.ShowDialog();

            var f2 = new View.SecondForm();
            f2.UserInfo = info;
            f2.ShowDialog();

            //Application.Run();
        }
    }
}
