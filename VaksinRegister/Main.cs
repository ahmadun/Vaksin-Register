using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaksinRegister
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btnsebelum_Click(object sender, EventArgs e)
        {
            RegistrationCheck fm = new RegistrationCheck();
            fm.ShowDialog();
        }

        private void Btnsetelah_Click(object sender, EventArgs e)
        {
            RegisterVaksined fm = new RegisterVaksined();
            fm.ShowDialog();
        }
    }
}
