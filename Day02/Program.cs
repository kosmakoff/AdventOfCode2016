using System;
using System.Linq;
using Common;
using Day02.Keypads;

namespace Day02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 2");

            var input = InputUtils.GetInput(args).ReadToEnd();

            var lines = input.Split('\n');

            var parser = new MoveDirectionParser();

            var clicker = new KeypadClicker(new DiamondKeypad());

            foreach (var line in lines)
            {
                var letters = line.Select(parser.Parse);

                foreach (var moveDirection in letters)
                {
                    clicker.Move(moveDirection);
                }

                Console.WriteLine(clicker.CurrentButton);
            }

            Console.ReadLine();
        }
    }
}
