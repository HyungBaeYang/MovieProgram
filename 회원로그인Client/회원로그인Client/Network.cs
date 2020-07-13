using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace 회원로그인Client
{
    internal enum NET_STATE
    {
        START,
        CONNECTED,
        DISCONNECT,
        DISCONNECTED,
    }
    internal class Network
    {
        //private NetworkStream stream;
        //private Thread readWorker_;
        //private TcpClient client_;
        //private NET_STATE state_ = NET_STATE.START;
      
        //public bool connect(string ip, uint port)
        //{
        //    client_ = new TcpClient();
        //    try
        //    {
        //        client_.Connect(ip, Convert.ToInt32(port));
        //    }
        //    catch
        //    {
        //        MessageBox.Show("서버 연결 실패", "error", MessageBoxButtons.OK);
        //        return false;
        //    }
        //    state_ = NET_STATE.CONNECTED;
        //    stream = client_.GetStream(); 

        //     readWorker_ = new Thread(new ThreadStart(receive));
        //    readWorker_.Start();

        //}
        

    }
}
