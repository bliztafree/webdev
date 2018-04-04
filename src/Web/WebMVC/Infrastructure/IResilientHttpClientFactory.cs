using Microsoft.bliztafree.BuildingBlocks.Resilience.Http;
using System;

namespace Microsoft.bliztafree.WebMVC.Infrastructure
{
    public interface IResilientHttpClientFactory
    {
        ResilientHttpClient CreateResilientHttpClient();
    }
}