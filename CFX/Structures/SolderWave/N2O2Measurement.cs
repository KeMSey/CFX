﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.SolderWave
{
    public class N2O2Measurement
    {
        public N2O2Location Location { get; set; }

        /// <summary>
        /// Gets or sets the o2 reading value in ppm.
        /// </summary>
        public double O2ReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the o2 setpoint in ppm.
        /// </summary>
        public double O2Setpoint { get; set; }

        /// <summary>
        /// Gets or sets the n2 reading value in %.
        /// </summary>
        public double N2ReadingValue { get; set; }

        /// <summary>
        /// Gets or sets the n2 setpoint in %.
        /// </summary>
        public double N2Setpoint { get; set; }
    }
}