﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderWave
{
    /// <summary>
    /// Flux head information.
    /// </summary>
    public class WaveFluxHead
    {
        /// <summary>
        /// 1 based sequence (1, 2, 3, ...)
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FluxHead"/> is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the process time reading value.
        /// </summary>
        public TimeSpan ProcessTimeReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the dose set value in %.
        /// </summary>
        public double DoseSetValue { get; set; }

        /// <summary>
        /// Gets or sets the dose reading point in %.
        /// </summary>
        public double DoseReadingPoint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [consumption measurement active] during the processing of the unit.
        /// </summary>
        public bool ConsumptionMeasurementActive { get; set; }

        /// <summary>
        /// Gets or sets the flux head1 axis1 consumption set value in ml.
        /// </summary>
        public double ConsumptionSetValue { get; set; }

        /// <summary>
        /// Gets or sets the flux head1 axis1 consumption reading point in ml.
        /// </summary>
        public double ConsumptionReadingPoint { get; set; }
    }
}