using MediaValet.Core.Commands;
using MediaValet.Core.Commands.Results;
using MediaValet.Infrastructure.Storage.Abstractions.Communication;
using Microsoft.Extensions.Logging;
using OrderAgent.Domain.Commands;
using System.Threading.Tasks;

namespace OrderAgent.Domain.Handlers.Orders
{
    public class OrderHandler : IHandler<CreateOrderCommand>
    {
        private readonly ILogger<OrderHandler> logger;
        private readonly IBusMessageReply busMessageReply;

        public OrderHandler(ILogger<OrderHandler> logger, IBusMessageReply busMessageReply)
        {
            this.logger = logger;
            this.busMessageReply = busMessageReply;
        }

        public async Task<ICommandResult> Handle(CreateOrderCommand command)
        {
            logger.LogInformation(command.OrderText);
            await busMessageReply.SendConfirmation(new MediaValet.Core.Confirmation
            {
                AgentId = command.AgentId,
                OrderId = command.OrderId,
                OrderStatus = "Processed"
            });
            return new SuccessResult();
        }
    }
}
