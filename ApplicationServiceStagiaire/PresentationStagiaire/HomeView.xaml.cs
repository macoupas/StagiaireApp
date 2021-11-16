using PresentationStagiaire.ViewModel;
using System;
using System.Windows;

namespace PresentationStagiaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();
            this.DataContext = new HomeViewModel();
            HomeViewModel.CloseAction = new Action(() => this.Close());
            HomeViewModel.Refresh = new Action(() => this.lstStagiaire.UpdateLayout());
        }
    }
}
