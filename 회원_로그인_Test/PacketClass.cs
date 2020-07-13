using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace 회원_로그인_Test
{

    public class S_C_RSP_ID_PW_SUCESS : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64)PacketType.C_S_REQ_ID_PW; }
        Int64 type() { return (Int64)PacketType.C_S_REQ_ID_PW; }
        public string id_;
        public string password_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        {
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
}
