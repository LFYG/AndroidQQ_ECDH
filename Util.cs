using System;

namespace AndroidQQ_8_4_1_4680_ECDH
{
    public static class Util
    {
        public static string ToHex(this byte[] bytes)
        {
            string ret = string.Empty;
            foreach (byte it in bytes)
            {
                ret += it.ToString("X2");
            }
            return ret;
        }

        public static byte[] ToBytes(this string hexStr)
        {
            hexStr = hexStr.Replace(" ", "");
            if ((hexStr.Length % 2) != 0)
                hexStr += " ";
            byte[] returnBytes = new byte[hexStr.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexStr.Substring(i * 2, 2), 16);
            return returnBytes;
        }
    }
}
