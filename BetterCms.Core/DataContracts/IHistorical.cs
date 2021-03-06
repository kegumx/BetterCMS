﻿using System;

using BetterCms.Core.DataContracts.Enums;

namespace BetterCms.Core.DataContracts
{
    /// <summary>
    /// Defines interface to access a basic page content properties.
    /// </summary>
    public interface IHistorical : IEntity
    {
        ContentStatus Status { get; }        

        DateTime? PublishedOn { get; }
        
        string PublishedByUser { get; }
    }
}
