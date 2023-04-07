using Microsoft.Extensions.Logging;
using Tasks.Telegram.Services.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Tasks.Telegram.Services
{
    public class UpdateHandler
    {
        private readonly ITelegramBotClient _botClient;
        private readonly ILogger<UpdateHandler> _logger;
        private readonly ITelegramMessageService _telegramMessageService;

        public UpdateHandler(ITelegramBotClient botClient, ILogger<UpdateHandler> logger, ITelegramMessageService telegramMessageParser)
        {
            _botClient = botClient;
            _logger = logger;
            _telegramMessageService = telegramMessageParser;
        }

        public async Task HandleUpdateAsync(Update update, CancellationToken cancellationToken)
        {
            var handler = update switch
            {
                { Message: { } message } => BotOnMessageReceived(message, cancellationToken),
                _ => UnknownUpdateHandlerAsync(update, cancellationToken)
            };

            await handler;
        }

        private async Task BotOnMessageReceived(Message message, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Receive message type: {MessageType}", message.Type);

            if (message.Text is not { } messageText)
                return;

            await _telegramMessageService.ReceiveMessageAsync(_botClient, message);
        }

        private Task UnknownUpdateHandlerAsync(Update update, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Unknown update type: {UpdateType}", update.Type);
            return Task.CompletedTask;
        }
    }
}
