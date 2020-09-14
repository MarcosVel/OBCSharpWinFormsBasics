using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBasics {
    class Program {
        static void Main(string[] args) {
            var frm = new MyForm();
            frm.FormClosed += (s, e) => Application.Exit();

            frm.Show();

            Application.Run();
            
        }
    }
}
