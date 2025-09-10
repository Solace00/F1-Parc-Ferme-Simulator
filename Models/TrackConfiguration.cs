using System.Collections.Generic;
using System.Linq; 
using System.Text.Json.Serialization;

namespace f1parcfermeoptimizer.Models
{
    public class TrackConfiguration
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public double TotalLength { get; set; } // in meters
        public int TotalLaps { get; set; }
        public List<TrackSegment> Segments { get; set; } = new(); // Simplified initialization

        [JsonIgnore]
        public int CornerCount => Segments.Count(s => s is CornerSegment); // Fixed Count usage

        [JsonIgnore]
        public double AverageCornerRadius => Segments
            .OfType<CornerSegment>() // Fixed OfType usage
            .Average(c => c.Radius);
    }
}
