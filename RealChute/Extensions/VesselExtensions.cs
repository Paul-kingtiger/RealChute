﻿/* RealChute was made by Christophe Savard (stupid_chris). You are free to copy, fork, and modify RealChute as you see
 * fit. However, redistribution is only permitted for unmodified versions of RealChute, and under attribution clause.
 * If you want to distribute a modified version of RealChute, be it code, textures, configs, or any other asset and
 * piece of work, you must get my explicit permission on the matter through a private channel, and must also distribute
 * it through the attribution clause, and must make it clear to anyone using your modification of my work that they
 * must report any problem related to this usage to you, and not to me. This clause expires if I happen to be
 * inactive (no connection) for a period of 90 days on the official KSP forums. In that case, the license reverts
 * back to CC-BY-NC-SA 4.0 INTL.*/

namespace RealChute.Extensions
{
    public static class VesselExtensions
    {
        #region Methods
        /// <summary>
        /// Returns the AGL altitude from this vessel at the desired position
        /// </summary>
        /// <param name="ASL">Sea level altitude of this vessel</param>
        public static double GetTrueAlt(this Vessel vessel, double ASL)
        {
            if (vessel.mainBody.pqsController == null) { return ASL; }
            double terrainAlt = vessel.pqsAltitude;
            if (vessel.mainBody.ocean && terrainAlt < 0) { terrainAlt = 0; }
            return ASL - terrainAlt;
        }
        #endregion
    }
}