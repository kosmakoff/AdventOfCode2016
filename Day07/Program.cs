using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 7");

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found");
                return;
            }

            var input = File.ReadAllText(fileName);


            var inputData = input
                .Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(Decompose)
                .ToList();

            var tlsAddresses = inputData
                .Where(h => h.OutParts.Any(AbbaRegex.IsMatch) && !h.InParts.Any(AbbaRegex.IsMatch));

            Console.WriteLine($"Count of addresses supporting TLS: {tlsAddresses.Count()}");

            var sslAddresses = inputData
                .Select(holder => new
                {
                    InPartMatches = GetMatches(holder.InParts),
                    OutPartMatches = GetMatches(holder.OutParts)
                })
                .Select(a =>
                        a.InPartMatches.SelectMany(@in => a.OutPartMatches, (@in, @out) => new {@in, @out})
                            .Where(@t => AbaMatch(@t.@in, @t.@out))
                            .Select(@t => new {InPart = @t.@in, OutPart = @t.@out})
                )
                .Where(a => a.Any());

            Console.WriteLine($"Count of addresses supporting SSL: {sslAddresses.Count()}");
        }

        private static bool AbaMatch(string @in, string @out)
        {
            return @in[0] == @out[1] && @in[1] == @out[0];
        }

        private static IEnumerable<string> GetMatches(IEnumerable<string> parts)
        {
            foreach (var part in parts)
            {
                var matches = AbaRegex.Matches(part);

                foreach (Match match in matches)
                {
                    yield return part.Substring(match.Index, 3);
                }
            }
        }

        private static readonly Regex AddressRegex = new Regex(@"^(?:(?<out>\w+)|(?:\[(?<in>\w+)\]))*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex AbbaRegex = new Regex(@"^\w*(\w)(\w)\2(?!\2)\1\w*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static readonly Regex AbaRegex = new Regex(@"(\w)(?!\1)(?=\w\1)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static AddressHolder Decompose(string address)
        {
            var match = AddressRegex.Match(address);

            var holder = new AddressHolder
            {
                InParts = match.Groups["in"].Captures.Cast<Capture>().Select(capture => capture.Value).ToList(),
                OutParts = match.Groups["out"].Captures.Cast<Capture>().Select(capture => capture.Value).ToList()
            };

            return holder;
        }

        private class AddressHolder
        {
            public IEnumerable<string> OutParts { get; set; }

            public IEnumerable<string> InParts { get; set; }
        }

    }
}
