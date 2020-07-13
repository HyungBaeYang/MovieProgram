using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 회원_로그인_Test
{
    internal enum PROGRAM_STATE
    {
        LOGIN,
        VIEWMOVIE,
        MAX,
    }
    internal class ProgramState
    {
        private PROGRAM_STATE state_;
        private FormState formState_ = null;
        private string name_;

        public delegate void putMessageDele(string msg);
        public event putMessageDele putMessage_;

        private void changeState()
        {
            switch (state_)
            {
                case PROGRAM_STATE.LOGIN:
                    formState_ = new LoginFormState();
                    break;

                case PROGRAM_STATE.VIEWMOVIE:
                    //formState_ = new ChattingFormState();
                    break;
            }

        }
        public void SendPacket(PacketInterface packet)
        {
            this.formState_.sendPacket(ref packet);
        }
    }
}
