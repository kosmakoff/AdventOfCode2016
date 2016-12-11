using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 9");

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found");
                return;
            }

            var input = File.ReadAllText(fileName).Trim();

            var decompressedFileLength = GetDecompressedFileLength(input, recurse: false);

            Console.WriteLine($"Decompressed file length: {decompressedFileLength}");

            var decompressedFileV2Length = GetDecompressedFileLength(input);

            Console.WriteLine($"Decompressed file v2 length: {decompressedFileV2Length}");
        }

        private static long GetDecompressedFileLength(string input, bool recurse = true)
        {
            long count = 0;

            using (var reader = new StringReader(input))
            {
                while (true)
                {
                    var nextChar = reader.Peek();

                    if (nextChar == '(')
                    {
                        var marker = ReadMarker(reader);

                        char[] buffer = new char[marker.Length];

                        reader.Read(buffer, 0, buffer.Length);

                        var subLength = recurse ? GetDecompressedFileLength(new string(buffer, 0, buffer.Length)) : buffer.Length;
                        count += subLength * marker.RepeatCount;
                    }
                    else if (nextChar == -1)
                        break;
                    else
                    {
                        reader.Read();
                        count++;
                    }
                }
            }

            return count;
        }

        private static Marker ReadMarker(TextReader reader)
        {
            reader.Read();

            var sb = new StringBuilder();

            int nextChar;

            while ((nextChar = reader.Read()) != ')')
            {
                sb.Append((char) nextChar);
            }

            var parts = sb.ToString().Split('x');

            return new Marker(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        private class Marker
        {
            public int Length { get; }

            public int RepeatCount { get; }

            public Marker(int length, int repeatCount)
            {
                Length = length;
                RepeatCount = repeatCount;
            }
        }
    }
}
