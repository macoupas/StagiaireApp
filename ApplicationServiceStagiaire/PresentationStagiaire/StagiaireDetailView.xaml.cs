using Core;
using PresentationStagiaire.ViewModel;
using System.Windows;

namespace PresentationStagiaire
{
    /// <summary>
    /// Interaction logic for StagiaireDetail.xaml
    /// </summary>
    public partial class StagiaireDetailView : Window
    {
        public StagiaireDetailView()
        {
            InitializeComponent();
            this.DataContext = new StagiaireDetailViewModel();
        }

        public StagiaireDetailView(StagiaireDTO stagiaire)
        {
            InitializeComponent();
            this.DataContext = new StagiaireDetailViewModel(stagiaire);
        }
    }
}