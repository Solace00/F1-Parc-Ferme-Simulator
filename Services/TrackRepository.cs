using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using f1parcfermeoptimizer.Models;

namespace f1parcfermeoptimizer.Services
{
    public class TrackRepository
    {
        private readonly Dictionary<string, TrackConfiguration> _tracks = new();
        private readonly string _tracksDirectory = "Tracks";

        public TrackRepository()
        {
            LoadDefaultTracks();
        }

        private void LoadDefaultTracks()
        {
            if (!Directory.Exists(_tracksDirectory))
            {
                Directory.CreateDirectory(_tracksDirectory);
                return;
            }

            var trackFiles = Directory.GetFiles(_tracksDirectory, "*.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter() }
            };

            foreach (var file in trackFiles)
            {
                try
                {
                    var json = File.ReadAllText(file);
                    var track = JsonSerializer.Deserialize<TrackConfiguration>(json, options);
                    if (track != null && !_tracks.ContainsKey(track.Name))
                    {
                        _tracks[track.Name] = track;
                    }
                }
                catch
                {
                    // Handle or log error as needed
                }
            }
        }

        public TrackConfiguration GetTrack(string name)
        {
            _tracks.TryGetValue(name, out var track);
            return track;
        }

        public List<string> GetAvailableTracks()
        {
            return new List<string>(_tracks.Keys);
        }
    }
}
