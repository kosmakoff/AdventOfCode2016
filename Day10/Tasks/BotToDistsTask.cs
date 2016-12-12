using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day10.Entities;

namespace Day10.Tasks
{
    public class BotToDistsTask : ITask
    {
        public Bot Bot { get; }

        public IDestination DestinationLower { get; }

        public IDestination DestinationHigher { get; }

        public BotToDistsTask(Bot bot, IDestination destinationLower, IDestination destinationHigher)
        {
            Bot = bot;
            DestinationLower = destinationLower;
            DestinationHigher = destinationHigher;
        }

        public bool AttemptToExecute(Action<ITask> inspectAction)
        {
            int lowerValue, higherValue;
            inspectAction?.Invoke(this);
            if (Bot.Retrieve(out lowerValue, out higherValue))
            {
                DestinationLower.Give(lowerValue);
                DestinationHigher.Give(higherValue);
                return true;
            }
            return false;
        }
    }
}
