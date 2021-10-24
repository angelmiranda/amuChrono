using amuNewCrono.ViewModels.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace amuNewCrono
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICronoViewModel _cronoViewModel;

        public MainWindow(ICronoViewModel cronoViewModel)
        {
            _cronoViewModel = cronoViewModel;
            DataContext = _cronoViewModel;

            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            _cronoViewModel.setCronoStart();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            _cronoViewModel.setCronoStop();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            _cronoViewModel.setCronoPause();
        }
    }
}
