namespace Ordering.API.Application.IntegrationEvents.EventHandling
{
    using Microsoft.bliztafree.BuildingBlocks.EventBus.Abstractions;
    using Microsoft.bliztafree.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
    using Ordering.API.Application.IntegrationEvents.Events;
    using System.Threading.Tasks;

    public class OrderPaymentFailedIntegrationEventHandler : 
        IIntegrationEventHandler<OrderPaymentFailedIntegrationEvent>
    {
        private readonly IOrderRepository _orderRepository;

        public OrderPaymentFailedIntegrationEventHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task Handle(OrderPaymentFailedIntegrationEvent @event)
        {
            var orderToUpdate = await _orderRepository.GetAsync(@event.OrderId);

            orderToUpdate.SetCancelledStatus();

            await _orderRepository.UnitOfWork.SaveEntitiesAsync();
        }
    }
}
