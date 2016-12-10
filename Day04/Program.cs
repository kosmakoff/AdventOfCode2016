using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 4");

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found");
                return;
            }

            var input = File.ReadAllText(fileName);

            var lines = input.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"^(?:(?<letters>[a-z]+)-)+(?<sectorid>\d+)\[(?<checksum>[a-z]*)\]$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            var noDecoys = lines.Select(line => regex.Match(line))
                .Where(NotDecoy)
                .ToList();

            var sumOfSectorIds = noDecoys
                .Select(GetSectorId)
                .Sum();

            Console.WriteLine($"Sum of sector IDs is {sumOfSectorIds}");

            var sector = noDecoys
                .Select(match => new {Name = Decrypt(match), SectorID = GetSectorId(match)})
                .FirstOrDefault(a => a.Name.Contains("northpole"));

            if (sector != null)
            {
                Console.WriteLine($"Northpole objects stored in Sector #{sector.SectorID} ({sector.Name})");
            }
        }

        private static int GetSectorId(Match match)
        {
            return int.Parse(match.Groups["sectorid"].Value);
        }

        private static bool NotDecoy(Match match)
        {
            if (!match.Success)
                return false;

            var letters = string.Join(string.Empty, match.Groups["letters"].Captures.Cast<Capture>().Select(capture => capture.Value));

            var checksum = match.Groups["checksum"].Value;

            var commonLettersGroups = letters
                .GroupBy(c => c)
                .GroupBy(grp => grp.Count())
                .OrderByDescending(grp => grp.Key)
                .SelectMany(grp => grp.OrderBy(g => g.Key))
                .Select(grp => grp.Key)
                .Take(5);

            var commonLetters = string.Join(string.Empty, commonLettersGroups);

            return checksum.Equals(commonLetters, StringComparison.OrdinalIgnoreCase);
        }

        private static string Decrypt(Match match)
        {
            int count = int.Parse(match.Groups["sectorid"].Value);
            var parts = match.Groups["letters"].Captures.Cast<Capture>().Select(capture => Shift(capture.Value, count));
            return string.Join(" ", parts);
        }

        private static string Shift(string source, int count)
        {
            return string.Join(string.Empty, source.Select(c => ShiftOne(c, count)));
        }

        private static char ShiftOne(char c, int count)
        {
            return (char) ((c - 'a' + count)%26 + 'a');
        }
    }
}
