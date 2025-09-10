using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace f1parcfermeoptimizer.Models
{
    [JsonDerivedType(typeof(StraightSegment), typeDiscriminator: "straight")]
    [JsonDerivedType(typeof(CornerSegment), typeDiscriminator: "corner")]

    public abstract class TrackSegment
    {
        public string Type { get; set; } = string.Empty;
        public double Length { get; set; } // in meters
    }

    public class StraightSegment : TrackSegment
    {
        public bool DRSAvailable { get; set; }
        public bool HasDRSZone { get; set; }
    }
}
