using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoTTP
{
    static class ByteTools
    {
        public static bool bigEndian = false;
        public static void WriteBytes(byte[] bytes, long offset, byte[] bytesToWrite)
        {
            for (int i = 0; i < bytesToWrite.Length; i++)
            {
                bytes[offset + i] = bytesToWrite[i];
            }
        }

        public static void WriteString(byte[] bytes, long offset, string value)
        {
            byte[] tmp = Encoding.ASCII.GetBytes(value);
            for (int i = 0; i < tmp.Length; i++)
            {
                bytes[offset + i] = tmp[i];
            }

        }
        public static void WriteUInt(byte[] bytes, long offset, uint value)
        {
            byte[] tmp = BitConverter.GetBytes(value);
            if (bigEndian)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[offset + 3 - i] = tmp[i];
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[offset + i] = tmp[i];
                }
            }
        }
        public static uint ReadUInt(byte[] bytes, long offset)
        {
            if (bigEndian)
            {
                return (uint) ((bytes[offset] << 24) | (bytes[offset + 1] << 16) | (bytes[offset + 2] << 8) | bytes[offset + 3]);
            }
            else
            {
                return (uint)((bytes[offset + 3] << 24) | (bytes[offset + 2] << 16) | (bytes[offset + 1] << 8) | bytes[offset]);
            }
        }

        public static bool ReadBoolean(byte[] bytes, long offset)
        {
            if (bigEndian)
            {
                return bytes[offset + 3] != 0;
            }
            else
            {
                return bytes[offset] != 0;
            }
        }
    }
}
