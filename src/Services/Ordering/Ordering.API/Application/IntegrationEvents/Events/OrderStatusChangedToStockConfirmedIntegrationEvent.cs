﻿namespace Ordering.API.Application.IntegrationEvents.Events
{
    using Microsoft.bliztafree.BuildingBlocks.EventBus.Events;

    public class OrderStatusChangedToStockConfirmedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public OrderStatusChangedToStockConfirmedIntegrationEvent(int orderId)
            => OrderId = orderId;
    }
}