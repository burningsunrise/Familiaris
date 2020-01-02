using System.Threading.Tasks;
using Discord.Commands;

namespace Familiaris
{
    public class CommandModules : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        [Alias("familiaris", "h")]
        public async Task HelpInfo()
        {
            await ReplyAsync(SearchLogic.Help());

        }
        
        [Command("ping")]
        [Alias("pong", "hello")]
        public Task PingAsync() => ReplyAsync("Pong!");

        [Command("ailment")]
        [Alias("debuff", "sickness", "dbuff")]
        public async Task AilmentInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetDebuffResults(msgText);
            await ReplyAsync(resp);
        }

        [Command("armor")]
        [Alias("gear", "ar")]
        public async Task ArmorInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetArmorResults(msgText);
            await ReplyAsync(resp);
        }

        [Command("item")]
        [Alias("search", "material")]
        public async Task ItemInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetItemResults(msgText);
            await ReplyAsync(resp);
        }

        [Command("monster")]
        [Alias("mon", "creature", "beast", "bug")]
        public async Task MonsterInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetMonsterResults(msgText);
            await ReplyAsync(resp);
        }

        [Command("weapon")]
        [Alias("weap", "wep", "elderseal")]
        public async Task WeaponInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetWeaponResults(msgText);
            await ReplyAsync(resp);
        }

        [Command("event")]
        [Alias("quest", "optional", "assigned")]
        public async Task EventInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetEventResults(msgText);
            await ReplyAsync(resp);
        }

        [Command("charm")]
        [Alias("neck", "necklace", "jewel")]
        public async Task CharmInfo([Remainder] string msgText)
        {
            var resp = await SearchLogic.GetCharmResults(msgText);
            await ReplyAsync(resp);
        }
        
    }
}