﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiimoteLib.DataTypes
{
    /// <summary>
	/// Point structure for floating point 3D positions (X, Y, Z)
	/// </summary>	
	public struct Point3F
    {
        /// <summary>
        /// X, Y, Z coordinates of this point
        /// </summary>
        public float X, Y, Z;

        /// <summary>
        /// Convert to human-readable string
        /// </summary>
        /// <returns>A string that represents the point</returns>
        public override string ToString()
        {
            return string.Format("{{X={0}, Y={1}, Z={2}}}", X, Y, Z);
        }

    }
}
