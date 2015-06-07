﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.ModAPI
{
    /// <summary>
    /// Ship welder interface
    /// </summary>
    public interface IMyShipWelder : Ingame.IMyShipWelder
    {
        /// <summary>
        /// True if welder is set to helper mode
        /// </summary>
        bool HelpOthers { get; set; }
    }
}
