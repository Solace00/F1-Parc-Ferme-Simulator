using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using f1parcfermeoptimizer.Models;
using System;
using System.Threading.Tasks;
using f1parcfermeoptimizer.Services;
using System.Collections.Generic;

namespace f1parcfermeoptimizer.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly TrackRepository _trackRepository;
        private readonly AdvancedSimulationService _simulationService;

        [ObservableProperty]
        private CarSetup _currentSetup;
        
        [ObservableProperty]
        private SimulationParameters _parameters;
        
        [ObservableProperty]
        private SimulationResults _result;
        
        [ObservableProperty]
        private bool _isSimulationRunning;
        
        [ObservableProperty]
        private TrackConfiguration _selectedTrack;
        
        [ObservableProperty]
        private List<string> _availableTracks;

        public MainViewModel()
        {
            _trackRepository = new TrackRepository();
            _simulationService = new AdvancedSimulationService(_trackRepository);

            CurrentSetup = new CarSetup();
            Parameters = new SimulationParameters();
            Result = new SimulationResults();
            IsSimulationRunning = false;

            AvailableTracks = _trackRepository.GetAvailableTracks();
            SelectedTrack = _trackRepository.GetTrack("Monza") ?? new TrackConfiguration();
        }

        [RelayCommand]
        private async Task RunSimulationAsync()
        {
            IsSimulationRunning = true;
            Result = await _simulationService.SimulateLapAsync(SelectedTrack, CurrentSetup, Parameters);
            IsSimulationRunning = false;
        }
    }
}
