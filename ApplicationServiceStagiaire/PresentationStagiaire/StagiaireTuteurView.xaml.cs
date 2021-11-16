using PresentationStagiaire.ViewModel;
using System;
using System.Windows;

namespace PresentationStagiaire
{
    /// <summary>
    /// Interaction logic for StagiaireTuteurView.xaml
    /// </summary>
    public partial class StagiaireTuteurView : Window
    {
        public StagiaireTuteurView()
        {
            InitializeComponent();
            this.DataContext = new StagiaireTuteurViewModel();
            StagiaireTuteurViewModel.CloseAction = new Action(() => this.Close());
        }
    }
}
