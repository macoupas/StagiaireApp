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
    public class HomeViewModel : INotifyPropertyChanged
    {
        ServiceStagiaireClient serviceStagiaire = new ServiceStagiaireClient();

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

        private ObservableCollection<StagiaireDTO> listStagiaire;
        private StagiaireDTO stagiaire = new StagiaireDTO();

        #endregion

        #region Propriétés

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

        public HomeViewModel()
        {
            listStagiaire = new ObservableCollection<StagiaireDTO>(GetListDb());
            DetailStagiaireCommand = new RelayCommands(ShowDetail);
            RefreshStagiaireCommand = new RelayCommands(RefreshFunction);
        }

        #endregion

        #region Commandes

        public static Action CloseAction { get; set; }
        public static Action Refresh { get; set; }
        public ICommand RefreshStagiaireCommand { get; set; }
        public ICommand DetailStagiaireCommand { get; set; }

        #endregion

        #region Methodes

        //recupère la liste de tout les stagiaire en base de données
        private List<StagiaireDTO> GetListDb()
        {
            var response = serviceStagiaire.ListAllStagiaire();
            if (response.IsSucces == true)
            {
                List<StagiaireDTO> stagiaires = new List<StagiaireDTO>();
                stagiaires = response.Data.ToList();
                return stagiaires;
            }
            return null;
        }

        private void ShowDetail()
        {
            //TODO: Implémenter cette fonctionnalitée
        }

        private void RefreshFunction()
        {
            //TODO : Gérer le booleen de retour du service métier et afficher un message en cas d'erreur
            ListStagiaire = new ObservableCollection<StagiaireDTO>(GetListDb());
        }

        #endregion
    }
}
