using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 회원_로그인_Test
{
    internal abstract class FormState
    {

        protected Form form_;
        protected Network network_;

        public abstract void open(string ip, uint port);

        protected void setForm()
        {
            form_.TopLevel = false;
            form_.Dock = System.Windows.Forms.DockStyle.Fill;
            Program.mainForm_.Invoke(new MethodInvoker(delegate ()
            {
                form_.Parent = Program.mainForm_.mainPanel_;
                form_.Show();
            }));
        }

        public void close()
        {
            Program.mainForm_.removePanelForm(ref form_);
            if (network_ != null)
                network_.disConnect();

            Thread.Sleep(1);
            form_.Hide();
        }

        public bool connectToServer(string ip, uint port)
        {
            if (network_ == null)
                network_ = new Network();

            return network_.connect(ip, port);
        }

        public void sendPacket(ref PacketInterface packet)
        {
            network_.sendPacket(packet);
        }

       
};

