using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 회원_로그인_Test.Login
{
    class LoginContents : ContentsProcess
    {
        public void S_ANS_ID_PW_FAIL(PacketInterface rowPacket)
        {
            MessageBox.Show("로그인 실패", "로그인", MessageBoxButtons.OK);
        }

        public void S_ANS_ID_PW_SUCCESS(PacketInterface rowPacket)
        {
            S_C_RSP_ID_PW_SUCESS packet = (S_C_RSP_ID_PW_SUCESS)rowPacket;

            Program.programState_.setState
        }
    }
}
