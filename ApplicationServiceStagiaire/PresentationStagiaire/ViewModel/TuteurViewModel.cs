using Core;
using PresentationStagiaire.RelayCommand;
using PresentationStagiaire.ServiceStagiaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PresentationStagiaire.ViewModel
{
    public class TuteurViewModel : INotifyPropertyChanged
    {
        ServiceStagiaireClient serviceStagiaire = new ServiceStagiaireClient();

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Commands

        public ICommand SaveUpdateCommand { get; set; }
        public ICommand DeleteStagiaireOfTuteurCommand { get; set; }
        public ICommand UpdateStagiaireListCommand { get; set; }

        #endregion

        #region Attributs

        private ScreenMode tuteurMode;
        private TuteurDTO currentTuteur;
        private StagiaireDTO currentStagiaire;
        private List<StagiaireDTO> listStagiaireOfTuteur;

        #endregion

        #region Propriété

        public TuteurDTO CurrentTuteur
        {
            get
            {
                return this.currentTuteur;
            }
            set
            {
                this.currentTuteur = value;
                NotifyPropertyChanged(nameof(CurrentTuteur));
            }
        }

        public StagiaireDTO CurrentStagiaire
        {
            get
            {
                return this.currentStagiaire;
            }
            set
            {
                this.currentStagiaire = value;
                NotifyPropertyChanged(nameof(CurrentStagiaire));
            }
        }

        public List<StagiaireDTO> ListStagiaireOfTuteur
        {
            get
            {
                return this.listStagiaireOfTuteur;
            }
            set
            {
                this.listStagiaireOfTuteur = value;
                NotifyPropertyChanged(nameof(ListStagiaireOfTuteur));
            }
        }

        #endregion

        #region Constructeur

        public TuteurViewModel()
        {
            tuteurMode = ScreenMode.Creation;
            this.currentTuteur = new TuteurDTO();
            SaveUpdateCommand = new RelayCommands(SaveUpdateExistingTuteur);
            UpdateStagiaireListCommand = new RelayCommands(ListStagiaireOfTuteurFunction);
            DeleteStagiaireOfTuteurCommand = new RelayCommands(DeleteStagiaireOfTuteurFunction);
        }

        public TuteurViewModel(TuteurDTO tuteur)
            : this()
        {
            tuteurMode = ScreenMode.Update;
            CurrentTuteur = tuteur;
            ListStagiaireOfTuteurFunction();
        }

        #endregion

        #region Methodes

        private void SaveUpdateExistingTuteur()
        {
            //TODO : Gérer le retour
            ResponseData<bool> result = null;

            if (tuteurMode == ScreenMode.Creation)
            {
                result = serviceStagiaire.AddTuteur(currentTuteur);
            }
            else
            {
                result = serviceStagiaire.UpdateExistingTuteur(currentTuteur);
            }
        }

        private void ListStagiaireOfTuteurFunction()
        {
            var response = serviceStagiaire.ListStagiaireOfTuteur(CurrentTuteur);
            if (response.IsSucces == true)
            {
                ListStagiaireOfTuteur = response.Data.ToList();
            }
        }

        private void DeleteStagiaireOfTuteurFunction()
        {
            //TODO : Gérer le retour
            serviceStagiaire.DeleteStagiaireOfTuteur(CurrentTuteur, CurrentStagiaire);
        }

        #endregion

    }
}