using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace 회원로그인Client
{

    public class PK_REQ_ID_PW : Packet
    {
        /*
        BYTE size;
        BYTE type;
        WORD id;
        string userID;
        string userPW;
        */

        public Byte size;
        public Byte type = PacketType.C_S_REQ_ID_PW;
        public Int64 id;
        public string userID;
        public string userPW;


        

        public void encode()
        {
            PacketUtil.encodeHeader(packet_, this.type);
        }



    }
}
