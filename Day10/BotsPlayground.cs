using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day10.Entities;

namespace Day10
{
    public class BotsPlayground
    {
        public IDictionary<int, Bot> Bots = new Dictionary<int, Bot>();
        public IDictionary<int, Output> Outputs = new Dictionary<int, Output>();

        public Bot GetBot(int id)
        {
            Bot bot;

            if (!Bots.TryGetValue(id, out bot))
            {
                bot = new Bot(id);
                Bots.Add(id, bot);
            }

            return bot;
        }

        public Output GetOutput(int id)
        {
            Output output;

            if (!Outputs.TryGetValue(id, out output))
            {
                output = new Output(id);
                Outputs.Add(id, output);
            }

            return output;
        }
    }
}
