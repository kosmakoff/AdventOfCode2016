using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day10.Tasks
{
    public interface ITask
    {
        bool AttemptToExecute(Action<ITask> inspectAction);
    }
}
