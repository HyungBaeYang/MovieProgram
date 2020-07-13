using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace 회원_로그인_Test
{
    public partial class Form1 : Form
    {
        //static string serverIP = "127.0.0.1";
        //static int port = 9000;
        //TcpClient client = new TcpClient(serverIP, port);
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            S_C_REQ_ID_PW packet = new S_C_REQ_ID_PW();
            packet.id_ = ID_Text.Text;
            packet.password_ = PW_Text.Text;
            Program.programState_.SendPacket(packet);


            //if(ID_Text.Text == "marine" && PW_Text.Text== "marine")
            //{
            //    this.Hide();
            //    MainForm mainform1 = new MainForm();
            //    mainform1.Show();
            //} else
            //{
            //    MessageBox.Show("아이디나 비밀번호를 확인해주세요 ! ");
            //}

        }

        private void ID_Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
