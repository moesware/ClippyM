using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace ClippyM.Modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        // making command echo and output
        [Command("echo")]
        public async Task Output([Remainder] string message)
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Response");
            embed.WithDescription(message);
            embed.WithColor(new Color(0,255,0));

            await Context.Channel.SendMessageAsync("", false, embed.Build());

        }

        //Command for multiple selction to choice for the bot
        [Command("choices")]
        public async Task choice([Remainder] string message)
        {
            string[] options = message.Split(new char[]{'|'}, StringSplitOptions.RemoveEmptyEntries);
            // for random numbers
            Random r = new Random();
            string selection = options[r.Next(0, options.Length)];

            var embed = new EmbedBuilder();
            embed.WithTitle("Choice for" + Context.User.Username);
            embed.WithDescription(selection);
            embed.WithColor(new Color(255, 255, 0));
            embed.WithThumbnailUrl("https://www.deviantart.com/anioco/art/Clippy-595855150");// use a image

            await Context.Channel.SendMessageAsync("", false, embed.Build());

        }


    }
}
