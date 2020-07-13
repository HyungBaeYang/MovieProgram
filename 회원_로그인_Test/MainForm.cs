using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 회원_로그인_Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            Program.programState_.setState(PROGRAM_STATE.LOGIN, null, 0);
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.programState_.close();
            this.Dispose();
            Application.Exit();
        }

        public void removePanelForm(ref Form form)
        {
            mainPanel_.Controls.Remove(form);
        }
    }
}
