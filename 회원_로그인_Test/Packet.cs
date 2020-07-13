using System;
using System.IO;

namespace 회원_로그인_Test
{
    public interface PacketInterface
    {
        void encode();
        void decode(byte[] packet, ref int offset);

        Int64 type();
        MemoryStream getStream();

    }

    public class PacketData
    {
        protected MemoryStream packet_ = new MemoryStream();
        ~PacketData()
        {
            packet_ = null;
        }
    }
}
