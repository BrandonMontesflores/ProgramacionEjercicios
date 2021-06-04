using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace ExaBot
{
    class Program
    {
        private static TelegramBotClient Bot;

        public static async Task Main()
        {
            //await new ClsRecibir().IniciarTelegram();
            await new ClsMostrar().InicioTelegram();
        }
    }
}
