using Avalonia.Controls;
using f1parcfermeoptimizer.ViewModels;

namespace f1parcfermeoptimizer.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}