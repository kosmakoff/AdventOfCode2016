using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Day05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 5");

            const string input = "abbhdwsy";

            var counter = 0;

            var sb = new StringBuilder(8);

            for (int i = 0; counter <8 && i < int.MaxValue; i++)
            {
                var subInput = $"{input}{i}";
                var md5 = CryptoHelper.GetMd5Hash(subInput);
                if (!md5.StartsWith("00000"))
                    continue;

                sb.Append(md5[5]);
                counter++;
            }

            Console.WriteLine($"The first door password is {sb}");

            sb = new StringBuilder(new string(' ', 8));
            var mem = new BitArray(8, false);

            for (int i = 0; i < int.MaxValue; i++)
            {
                var subInput = $"{input}{i}";
                var md5 = CryptoHelper.GetMd5Hash(subInput);
                if (!md5.StartsWith("00000"))
                    continue;

                var position = md5[5] - '0';

                if (position > 7)
                    continue;

                var c = md5[6];

                if (!mem.Get(position))
                {
                    sb[position] = c;
                    mem.Set(position, true);

                    if (mem.Cast<bool>().All(s => s))
                        break;
                }
            }

            Console.WriteLine($"The second door password is {sb}");
        }
    }
}
