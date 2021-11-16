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
    public class StagiaireDetailViewModel : INotifyPropertyChanged
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

        #endregion

        #region Attributs

        private ScreenMode stagiaireDetailMode;
        private StagiaireDTO currentStagiaire;
        private bool _isMasculin;
        private bool _isFeminin;
        private List<TuteurDTO> _listTuteurs;

        #endregion

        #region Propriété

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
                NotifyPropertyChanged(nameof(IsMasculin));
                NotifyPropertyChanged(nameof(IsFeminin));
            }
        }

        public bool IsMasculin
        {
            get
            {
                return this.CurrentStagiaire.Sexe == "M";
            }
            set
            {
                this._isMasculin = value;
                if (this._isMasculin)
                {
                    this.CurrentStagiaire.Sexe = "M";
                }
                else
                {
                    this.CurrentStagiaire.Sexe = "F";
                }
                NotifyPropertyChanged(nameof(IsMasculin));
                NotifyPropertyChanged(nameof(ImageSource));
            }
        }

        public bool IsFeminin
        {
            get
            {
                return this.CurrentStagiaire.Sexe == "F";
            }
            set
            {
                this._isFeminin = value;
                if (this._isFeminin)
                {
                    this.CurrentStagiaire.Sexe = "F";
                }
                else
                {
                    this.CurrentStagiaire.Sexe = "M";
                }
                NotifyPropertyChanged(nameof(IsFeminin));
                NotifyPropertyChanged(nameof(ImageSource));
            }
        }

        public string ImageSource
        {
            get
            {
                return IsMasculin ? @"./Ressources/Men.png" : @"./Ressources/Woman.png";
            }
        }

        public List<TuteurDTO> ListTuteurs
        {
            get
            {
                return this._listTuteurs;
            }
            set
            {
                this._listTuteurs = value;
                NotifyPropertyChanged(nameof(ListTuteurs));
            }
        }

        #endregion

        #region Constructeur

        public StagiaireDetailViewModel()
        {
            ListTuteurs = GetListTuteurDb();
            stagiaireDetailMode = ScreenMode.Creation;
            this.CurrentStagiaire = new StagiaireDTO();
            SaveUpdateCommand = new RelayCommands(SaveUpdateExistingStagiaire);
        }

        public StagiaireDetailViewModel(StagiaireDTO stagiaire)
            :this()
        {
            ListTuteurs = GetListTuteurDb();
            stagiaireDetailMode = ScreenMode.Update;
            this.CurrentStagiaire = stagiaire;
        }

        #endregion

        #region Methodes

        //recupère la liste de tout les tuteurs en base de données
        private List<TuteurDTO> GetListTuteurDb()
        {
            var response = serviceStagiaire.ListAllTuteur();
            if (response.IsSucces == true)
            {
                List<TuteurDTO> tuteurs = new List<TuteurDTO>();
                tuteurs = response.Data.ToList();
                return tuteurs;
            }
            return null;
        }

        private void SaveUpdateExistingStagiaire()
        {
            //TODO : Gérer le retour
            ResponseData<bool> result = null;

            if (stagiaireDetailMode == ScreenMode.Creation)
            {
                result = serviceStagiaire.AddStagiaire(currentStagiaire);
            }
            else
            {
                result = serviceStagiaire.UpdateExistingStagiaire(currentStagiaire);
            }
        }

        #endregion
    }
}
