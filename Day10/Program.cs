using Antlr4.Runtime;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Tree;
using Day10.Tasks;

namespace Day10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 10");

            var input = new AntlrInputStream(InputUtils.GetInput(args));
            var lexer = new BotsScriptLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new BotsScriptParser(tokens);
            var program = parser.program();

            IList<ITask> tasks = new List<ITask>();
            var botsPlayground = new BotsPlayground();
            var listener = new ExecutingListener(tasks, botsPlayground);

            var walker = new ParseTreeWalker();
            walker.Walk(listener, program);

            while (tasks.Any())
            {
                foreach (var task in tasks)
                {
                    if (task.AttemptToExecute(Inspect))
                    {
                        tasks.Remove(task);
                        break;
                    }
                }
            }

            var output0 = botsPlayground.GetOutput(0);
            var output1 = botsPlayground.GetOutput(1);
            var output2 = botsPlayground.GetOutput(2);

            Console.WriteLine($"O0 * O1 * O2 = {output0.Value*output1.Value*output2.Value}");

        }

        private static void Inspect(ITask obj)
        {
            var botToDistsTask = obj as BotToDistsTask;

            if (botToDistsTask?.Bot.LowerValue == 17 && botToDistsTask.Bot.HigherValue == 61)
                Console.WriteLine($"Found bot #{botToDistsTask.Bot.Id}");
        }
    }
}
