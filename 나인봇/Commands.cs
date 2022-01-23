using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace 나인봇
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        [Alias("ping!", "핑", "핑!")]
        public async Task ping()
        {
            await Context.Channel.SendMessageAsync($"pong!🏓 {ping}ms");
        }
    }
}
