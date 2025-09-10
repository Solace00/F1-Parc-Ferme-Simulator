using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using f1parcfermeoptimizer.Models;
using System;
using System.Threading.Tasks;

namespace f1parcfermeoptimizer.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private CarSetup _currentSetup;

        [ObservableProperty]
        private SimulationParameters _parameters;

        [ObservableProperty]
        private SimulationResults _result;

        [ObservableProperty ]
        private bool _isSimulationRunning;

        public MainViewModel()
        {
            CurrentSetup = new CarSetup();
            Parameters = new SimulationParameters();
            Result = new SimulationResults();
            IsSimulationRunning = false;

            Console.WriteLine("ViewModel created!"); // Debug output
        }

        [RelayCommand]
        private async Task RunSimulationAsync()
        {
            Console.WriteLine("Simulation started!"); // Debug output
            IsSimulationRunning = true;

            // Simulate a delay for the simulation process
            await Task.Delay(2000); // Simulate a 2-second delay

            // Dummy Calculations for Testing
            Result.QualifyingLapTime = 80.0 - (CurrentSetup.FrontWingRight + CurrentSetup.FrontWingLeft + CurrentSetup.RearWing) * 0.1;

            Result.RaceLapTime = 82.0 - (CurrentSetup.FrontWingRight + CurrentSetup.FrontWingLeft + CurrentSetup.RearWing) * 0.05 ;

            IsSimulationRunning = false;

            // Explicitly notify UI that these properties changed
            OnPropertyChanged(nameof(Result));
        }
    }
}
