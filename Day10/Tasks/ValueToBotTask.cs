using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day10.Entities;

namespace Day10.Tasks
{
    public class ValueToBotTask : ITask
    {
        public int Value { get; }

        public Bot Bot { get; }

        public ValueToBotTask(int value, Bot bot)
        {
            Value = value;
            Bot = bot;
        }

        public bool AttemptToExecute(Action<ITask> inspectAction)
        {
            Bot.Give(Value);
            return true;
        }
    }
}
