using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoTTP
{
    public class Stz
    {
        public string name;
        public byte[][] data = new byte[6][];

        public Stz(string name, byte[] rawStz)
        {
            this.name = name;
            ReadRawStz(rawStz);
        }

        public Stz(string name, byte[][] data)
        {
            this.name = name;
            this.data = data;
        }

        public Stz(string name, byte[] dat, byte[] rel)
        {
            this.name = name;
            data[4] = dat;
            data[5] = dat;
        }

        public byte[] GetRawStz()
        {
            return null;
        }

        private void ReadRawStz(byte[] rawStz)
        {
            for (int i = 0; i < 6; i++)
            {
                uint offset = ByteTools.ReadUInt(rawStz, i * 12);
                uint decompressedLength = ByteTools.ReadUInt(rawStz, i * 12 + 4);
                uint compressedLength = ByteTools.ReadUInt(rawStz, i * 12 + 8);
                
                if (compressedLength > 0)
                {
                    data[i] = Decompress(rawStz, offset, compressedLength, decompressedLength);
                }
                else
                {
                    data[i] = new byte[0];
                }
            }
        }

        public static byte[] Decompress(byte[] bytes, uint offset, uint compressedLength, uint decompressedLength)
        {
            using (MemoryStream byteStream = new MemoryStream(bytes, (int)offset, (int)compressedLength))
            {
                byteStream.Seek(2, SeekOrigin.Current);
                using (DeflateStream decompressionStream = new DeflateStream(byteStream, CompressionMode.Decompress))
                {
                    byte[] outBytes = new byte[decompressedLength];
                    decompressionStream.Read(outBytes, 0, (int)decompressedLength);
                    return outBytes;
                }
            }
        }
    }
}
