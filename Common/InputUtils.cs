using System;
using System.IO;

namespace Common
{
    public class InputUtils
    {
        public static TextReader GetInput(string[] args)
        {
            string inputFile = null;
            if (args.Length > 0) inputFile = args[0];
            TextReader istream;
            if (inputFile != null)
            {
                if (File.Exists(inputFile))
                    istream = File.OpenText(inputFile);
                else
                    throw new FileNotFoundException($"Could not find file at path '{inputFile}'");
            }
            else
            {
                istream = Console.In;
            }

            return istream;
        }
    }
}
