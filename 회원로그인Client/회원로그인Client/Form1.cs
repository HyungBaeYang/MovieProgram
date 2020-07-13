using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace 회원로그인Client
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("127.0.0.1", Convert.ToInt32("9000"));
            NetworkStream stream = client.GetStream();
            MessageBox.Show("서버 연결에 성공 했습니다..");
           


            //updateStatusInfo("Connected");


            this.Hide();

            MainForm mainForm1 = new MainForm();
            mainForm1.Show();

        }
    }
}
