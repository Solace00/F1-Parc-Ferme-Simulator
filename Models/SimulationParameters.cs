using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1parcfermeoptimizer.Models
{
    public class SimulationParameters
    {
        public String TrackName { get; set; }
        public double TrackLength { get; set; } // in kilometers
        public int NumberOfLaps { get; set; }
        public string WeatherCondition { get; set; } // e.g., "dry", "wet"
        public double Temperature { get; set; } // in Celsius
        public double FuelLoad { get; set; } // in kilograms
        public bool EnabledDRS { get; set; }

        
        public SimulationParameters()
        {
            // Default values
            TrackName = "Monza";
            TrackLength = 5.793; // Monza length in km
            NumberOfLaps = 53; // Typical
            WeatherCondition = "dry";
            Temperature = 25.0; // Default temperature
            FuelLoad = 100.0; // Default fuel load in kg
            EnabledDRS = true;
        }
    }
}
