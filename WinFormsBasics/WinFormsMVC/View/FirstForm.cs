using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC {
    public partial class FirstForm : Form {
        public FirstForm() {
            InitializeComponent();
        }

        public UserInfo UserInfo { get; set; }

        private void btnNext_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FirstForm_Load(object sender, EventArgs e) {
            txtFirstName.Text = UserInfo.FirstName;
            txtLastName.Text = UserInfo.LastName;
            txtEmailAddress.Text = UserInfo.EmailAddress;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) {
            UserInfo.FirstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e) {
            UserInfo.LastName = txtLastName.Text;
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e) {
            UserInfo.EmailAddress = txtEmailAddress.Text;
        }
    }
}
