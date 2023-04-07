using Telegram.Bot;
using Telegram.Bot.Types;

namespace Tasks.Telegram.Services.Interfaces
{
    public interface ITelegramMessageService
    {
        Task ReceiveMessageAsync(ITelegramBotClient botClient, Message message);
    }
}
