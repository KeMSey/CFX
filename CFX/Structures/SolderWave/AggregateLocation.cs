﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderWave
{
    /// <summary>
    /// An enumeration indicating different types of stages that might exist at an endpoint. 
    /// </summary>
    public enum AggregateLocation
    {
        /// <summary>
        /// Top and bottom of the aggregate.
        /// </summary>
        WholeAggregate = 0,
        /// <summary>
        /// Only the top of the aggregate.
        /// </summary>
        Top = 1,
        /// <summary>
        /// Only the bottom of the aggregate.
        /// </summary>
        Bottom = 2
    }
}