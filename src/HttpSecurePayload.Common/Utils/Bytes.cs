using System.IO;
using System.Linq;

namespace HttpSecurePayload.Common
{
    internal static class Bytes
    {
        internal static ushort CRC16(this byte[] source, ushort crc = 0)
        {
            return Utils.CRC16.Compute(source, crc);
        }

        internal static byte[] XOR(this byte[] source, byte[] password)
        {
            var ret = new byte[source.Length];
            for(int index = 0; index < source.Length; index++)
            {
                ret[index] = (byte)(source[index] ^ password[index % password.Length]);
            }
            return ret;
        }

        internal static byte[] Combine(this byte[] source, params byte[][] anothers)
        {
            using (var ms = new MemoryStream(source))
            {
                foreach (var another in anothers)
                    ms.Write(another, 0, another.Length);
                ms.Position = 0;
                return ms.ToArray();
            }
        }
    }
}
