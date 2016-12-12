using System.Security.Cryptography;
using System.Text;

namespace Day05
{
    public static class CryptoHelper
    {
        private static readonly MD5 Md5;

        static CryptoHelper()
        {
            Md5 = MD5.Create();
        }

        public static string GetMd5Hash(string input)
        {
            var bytes = Encoding.ASCII.GetBytes(input);
            var md5 = Md5.ComputeHash(bytes);
            return BytesToString(md5);
        }

        public static string BytesToString(byte[] bytes)
        {
            var sb = new StringBuilder(bytes.Length * 2);

            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
