﻿using bliztafree.Core.Models.Location;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace bliztafree.Core.Services.Location
{
    public interface ILocationServiceImplementation
    {
        double DesiredAccuracy { get; set; }
        bool IsGeolocationAvailable { get; }
        bool IsGeolocationEnabled { get; }

        Task<Position> GetPositionAsync(TimeSpan? timeout = null, CancellationToken? token = null);
    }
}
