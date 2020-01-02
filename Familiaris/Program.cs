using System;
using System.Configuration;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Familiaris
{
    class Program
    {
        private DiscordSocketClient _client;
        private CommandHandler _handler;
        private CommandService _commands;
        
        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, ConfigurationManager.AppSettings["clientKey"]);
            await _client.StartAsync();
            
            // Register commands
            _commands = new CommandService();
            _handler = new CommandHandler(_client, _commands);
            await _handler.InstallCommandsAsync();

            // Block this task until the client is closed
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}