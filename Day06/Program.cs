using System;
using System.Linq;
using System.Text;
using Common;

namespace Day06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 6");

            var input = InputUtils.GetInput(args).ReadToEnd();

            var datas = input.Split(new [] {'\n'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var length = datas.First().Length;

            var sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                var commonLetter = datas.Select(d => d[i])
                    .GroupBy(c => c)
                    .OrderByDescending(grp => grp.Count())
                    .Select(grp => grp.Key)
                    .First();

                sb.Append(commonLetter);
            }

            Console.WriteLine($"The message is '{sb}'");

            sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                var commonLetter = datas.Select(d => d[i])
                    .GroupBy(c => c)
                    .OrderBy(grp => grp.Count())
                    .Select(grp => grp.Key)
                    .First();

                sb.Append(commonLetter);
            }

            Console.WriteLine($"The REAL message is '{sb}'");
        }
    }
}
