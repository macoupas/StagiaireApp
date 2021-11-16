using Core;
using PresentationStagiaire.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PresentationStagiaire
{
    /// <summary>
    /// Interaction logic for TuteurView.xaml
    /// </summary>
    public partial class TuteurView : Window
    {
        public TuteurView()
        {
            InitializeComponent();
            this.DataContext = new TuteurViewModel();
        }

        public TuteurView(TuteurDTO tuteur)
        {
            InitializeComponent();
            this.DataContext = new TuteurViewModel(tuteur);
        }
    }
}
