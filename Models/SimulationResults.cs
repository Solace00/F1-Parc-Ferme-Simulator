using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace f1parcfermeoptimizer.Models
{
    public class SimulationResults : INotifyPropertyChanged
    {
        private double qualifyingLapTime;
        private double raceLapTime;

        public double QualifyingLapTime
        {
            get => qualifyingLapTime;
            set
            {
                if (qualifyingLapTime != value)
                {
                    qualifyingLapTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public double RaceLapTime
        {
            get => raceLapTime;
            set
            {
                if (raceLapTime != value)
                {
                    raceLapTime = value;
                    OnPropertyChanged();
                }
            }
        }

        // Declare the event as nullable
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            // Use null-conditional operator
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}