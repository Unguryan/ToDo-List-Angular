using MediatR;
using Tasks.App.CQRS.Commands.Tokens.AddToken;
using Tasks.App.CQRS.Commands.Users.AddUser;
using Tasks.App.CQRS.Commands.Users.IsTelegramUserExist;
using Tasks.App.CQRS.Commands.Users.NotifyUser;
using Tasks.Domain.Events;
using Tasks.Domain.Models;
using Tasks.Telegram.Services.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using User = Tasks.Domain.Models.User;

namespace Tasks.Telegram.Services
{
    public class TelegramMessageService : ITelegramMessageService
    {
        private readonly IMediator _mediator;

        public TelegramMessageService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task ReceiveMessageAsync(ITelegramBotClient botClient, Message message)
        {
            if (!string.IsNullOrEmpty(message.Text) && message.Text.StartsWith("/start auth="))
            {

                User? user = null;

                var isUserExist = await _mediator.Send(new IsTelegramUserExistCommand(message.From.Id.ToString()));

                if (!isUserExist.IsExist)
                {
                    var userRes = await _mediator.Send(new AddUserCommand(message.From.FirstName, message.From.Id.ToString()));
                    user = userRes.CreatedUser;
                }
                else
                {
                    user = isUserExist.TelUser;
                }

                var authCode = message.Text.Replace("/start auth=", "");
                var chatId = new ChatId(message.From.Id);

                if (user != null)
                {
                    var token = await _mediator.Send(new AddTokenCommand(user));

                    var @event = new LoggedByTelegramEvent(authCode, token.Token.TokenData);
                    await _mediator.Send(new NotifyUserCommand(@event));

                    await botClient.SendTextMessageAsync(chatId, "Success. Return to the page.");
                }
                else
                {
                    var @event = new AuthErrorEvent(authCode, "Error. User has been not created.");
                    await _mediator.Send(new NotifyUserCommand(@event));

                    await botClient.SendTextMessageAsync(chatId, "Error. Return to the page.");
                }
            }
        }
    }
}
