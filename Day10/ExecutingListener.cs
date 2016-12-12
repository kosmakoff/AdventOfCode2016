using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day10.Entities;
using Day10.Tasks;

namespace Day10
{
    public class ExecutingListener : BotsScriptBaseListener
    {
        private readonly IList<ITask> _botsTasks;
        private readonly BotsPlayground _playground;

        public ExecutingListener(IList<ITask> botsTasks, BotsPlayground playground)
        {
            _botsTasks = botsTasks;
            _playground = playground;
        }

        public override void EnterValueToBot(BotsScriptParser.ValueToBotContext context)
        {
            var value = context.value().val.Text;
            var botId = context.bot().id.Text;

            var intValue = int.Parse(value);
            var intBotId = int.Parse(botId);

            _botsTasks.Add(new ValueToBotTask(intValue, _playground.GetBot(intBotId)));
        }

        public override void EnterBotToDest(BotsScriptParser.BotToDestContext context)
        {
            var botId = context.bot().id.Text;

            var destLower = ParseDest(context.dest(0));
            var destHigher = ParseDest(context.dest(1));

            var bot = _playground.GetBot(int.Parse(botId));

            _botsTasks.Add(new BotToDistsTask(bot, destLower, destHigher));
        }

        private IDestination ParseDest(BotsScriptParser.DestContext destContext)
        {
            var bot = destContext.bot();
            var output = destContext.output();

            if (bot != null)
            {
                return _playground.GetBot(int.Parse(bot.id.Text));
            }

            if (output != null)
            {
                return _playground.GetOutput(int.Parse(output.id.Text));
            }

            throw new ArgumentException();
        }
    }
}
