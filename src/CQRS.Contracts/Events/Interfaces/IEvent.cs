﻿using System;

namespace CQRS.Contracts.Events.Interfaces
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}