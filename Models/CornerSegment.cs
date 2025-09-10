using System.Text.Json.Serialization;

namespace f1parcfermeoptimizer.Models
{
    public enum CornerType
    {
        Left,       // Standard left-hand corner
        Right,      // Standard right-hand corner
        Chicane,    // Series of alternating corners
        Hairpin,    // Very tight corner (180° or close)
        Esses,      // S-shaped sequence of corners
        Sweeper,    // Long, gradual corner
        Kink        // Very slight corner
    }

    public class CornerSegment : TrackSegment
    {
        public CornerType CornerType { get; set; } // e.g., "left", "right", "chicane"
        public double Radius { get; set; } // in meters
        public double Angle { get; set; } // in degrees
        public double ApexSpeed { get; set; } // in km/h
        public int Difficulty { get; set; } // Scale of 1-5 for tire stress
    }

}
