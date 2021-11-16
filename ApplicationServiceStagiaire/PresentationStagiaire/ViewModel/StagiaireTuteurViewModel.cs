using Core;
using PresentationStagiaire.RelayCommand;
using PresentationStagiaire.ServiceStagiaire;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PresentationStagiaire.ViewModel
{
    public class StagiaireTuteurViewModel : INotifyPropertyChanged
    {
        ServiceStagiaireClient serviceStagiaireTuteur = new ServiceStagiaireClient();

        #region Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Attributs

        private ObservableCollection<TuteurDTO> listTuteur;
        private ObservableCollection<StagiaireDTO> listStagiaire;
        private TuteurDTO tuteur = new TuteurDTO();
        private StagiaireDTO stagiaire = new StagiaireDTO();

        #endregion

        #region Propriétés

        public ObservableCollection<TuteurDTO> ListTuteur
        {
            get
            {
                return listTuteur;
            }
            private set
            {
                if (value != this.listTuteur)
                {
                    this.listTuteur = value;
                    NotifyPropertyChanged(nameof(ListTuteur));
                }
            }
        }

        public ObservableCollection<StagiaireDTO> ListStagiaire
        {
            get
            {
                return listStagiaire;
            }
            private set
            {
                if (value != this.listStagiaire)
                {
                    this.listStagiaire = value;
                    NotifyPropertyChanged(nameof(ListStagiaire));
                }
            }
        }

        public TuteurDTO Tuteur
        {
            get
            {
                return tuteur;
            }

            set
            {
                if (value != this.tuteur)
                {
                    this.tuteur = value;
                    NotifyPropertyChanged(nameof(Tuteur));
                }
            }
        }

        public StagiaireDTO Stagiaire
        {
            get
            {
                return stagiaire;
            }

            set
            {
                if (value != this.stagiaire)
                {
                    this.stagiaire = value;
                    NotifyPropertyChanged(nameof(Stagiaire));
                }
            }
        }

        #endregion

        #region Constructeur

        public StagiaireTuteurViewModel()
        {
            ListTuteur = new ObservableCollection<TuteurDTO>(GetListTuteurDb());
            ListStagiaire = new ObservableCollection<StagiaireDTO>(GetListStagiaireDb());
            DetailTuteurCommand = new RelayCommands(ShowDetailTuteur);
            DetailStagiaireCommand = new RelayCommands(ShowDetailStagiaire);
            DeleteTuteurCommand = new RelayCommands(DeleteTuteurFunction);
            DeleteStagiaireCommand = new RelayCommands(DeleteStagiaireFunction);
            AddTuteurCommand = new RelayCommands(AddTuteurFunction);
            AddStagiaireCommand = new RelayCommands(AddStagiaireFunction);
            UpdateStagiaireCommand = new RelayCommands(UpdateStagiaireFunction);
            UpdateTuteurCommand = new RelayCommands(UpdateTuteurFunction);
            RefreshStagiaireTuteurCommand = new RelayCommands(RefreshFunction);
        }

        #endregion

        #region Commandes

        public static Action CloseAction { get; set; }
        public static Action Refresh { get; set; }
        public ICommand RefreshStagiaireTuteurCommand { get; set; }
        public ICommand AddTuteurCommand { get; set; }
        public ICommand AddStagiaireCommand { get; set; }
        public ICommand DetailTuteurCommand { get; set; }
        public ICommand DetailStagiaireCommand { get; set; }
        public ICommand DeleteTuteurCommand { get; set; }
        public ICommand DeleteStagiaireCommand { get; set; }
        public ICommand UpdateStagiaireCommand { get; set; }
        public ICommand UpdateTuteurCommand { get; set; }

        #endregion

        #region Methodes

        //recupère la liste de tout les tuteurs en base de données
        private List<TuteurDTO> GetListTuteurDb()
        {
            var response = serviceStagiaireTuteur.ListAllTuteur();
            if (response.IsSucces == true)
            {
                List<TuteurDTO> tuteurs = new List<TuteurDTO>();
                tuteurs = response.Data.ToList();
                return tuteurs;
            }
            return null;
        }

        //recupère la liste de tout les stagiaires en base de données
        private List<StagiaireDTO> GetListStagiaireDb()
        {
            var response = serviceStagiaireTuteur.ListAllStagiaire();
            if (response.IsSucces == true)
            {
                List<StagiaireDTO> stagiaires = new List<StagiaireDTO>();
                stagiaires = response.Data.ToList();
                return stagiaires;
            }
            return null;
        }

        private void ShowDetailTuteur()
        {
            TuteurView tuteurView = new TuteurView(Tuteur);
            tuteurView.Show();
        }

        private void ShowDetailStagiaire()
        {
            StagiaireDetailView stagiaireDetailView = new StagiaireDetailView(Stagiaire);
            stagiaireDetailView.Show();
        }

        private void RefreshFunction()
        {
            //TODO : Gérer le booleen de retour du service métier et afficher un message en cas d'erreur
            ListTuteur = new ObservableCollection<TuteurDTO>(GetListTuteurDb());
            ListStagiaire = new ObservableCollection<StagiaireDTO>(GetListStagiaireDb());
        }

        private void DeleteTuteurFunction()
        {
            //TODO : Gérer le booleen de retour du service métier et afficher un message en cas d'erreur
            serviceStagiaireTuteur.DeleteTuteur(Tuteur);
            ListTuteur = new ObservableCollection<TuteurDTO>(GetListTuteurDb());
        }

        private void DeleteStagiaireFunction()
        {
            //TODO : Gérer le booleen de retour du service métier et afficher un message en cas d'erreur
            serviceStagiaireTuteur.DeleteStagiaire(Stagiaire);
            ListStagiaire = new ObservableCollection<StagiaireDTO>(GetListStagiaireDb());
        }

        private void AddTuteurFunction()
        {
            TuteurView tuteurView = new TuteurView();
            tuteurView.Show();
        }

        private void AddStagiaireFunction()
        {
            //TODO : Gérer le booleen de retour du service métier et afficher un message en cas d'erreur
            StagiaireDetailView stagiaireDetailView = new StagiaireDetailView();
            stagiaireDetailView.Show();
        }

        private void UpdateStagiaireFunction()
        {
            StagiaireDetailView stagiaireDetailView = new StagiaireDetailView(Stagiaire);
            stagiaireDetailView.Show();
        }

        private void UpdateTuteurFunction()
        {
            TuteurView tuteurView = new TuteurView(Tuteur);
            tuteurView.Show();
        }

        #endregion
    }
}
