using System;

namespace SelfOrdering.CrossCutting
{
    public class DistanceHelper
    {
        /// <summary>
        /// The distance type to return the results in.
        /// </summary>
        public enum DistanceType { Miles, Kilometers };
 
        /// <summary>
        /// Specifies a Latitude / Longitude point.
        /// </summary>
        public struct Position
        {
            public double Latitude;
            public double Longitude;
        }
        
        public double CalculateDistance(Position pos1, Position pos2,DistanceType type)
        {
            var R = (type == DistanceType.Miles) ? 3960 : 6371;
 
            var dLat = this.toRadian((pos2.Latitude - pos1.Latitude));
            var dLon = this.toRadian(pos2.Longitude - pos1.Longitude);
 
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(this.toRadian(pos1.Latitude)) *Math.Cos(this.toRadian(pos2.Latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            var d = R * c;
 
            return d;
        }
 
        /// <summary>
        /// Convert to Radians.
        /// </summary>
        /// <param name=”val”></param>
        /// <returns></returns>
        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}
